using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;
using System.Text;
using ISSI.PartnerManagementSystem.BusinessObjects;
namespace ISSI.PartnerManagementSystem.Web
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString);

        private User _user = new User();
        public User SelectedUser
        {
            set { _user = value; }
            get { return _user; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            SelectedUser.UserId = Guid.Parse(Request.QueryString["UserId"].ToString());
            if (!IsPostBack)
            {
                GetUser();
                BindTextboxValues();
                GetDropDown();
            }
            else
            {
                BindSelectedUser();
                
            }
        }

        private void GetUser()
        {

            SqlCommand cmd = new SqlCommand("select ID,cuser,cpass,email,mobile,dob from c_details where ID= '" + SelectedUser.UserId.ToString() + "'", conn);
           // SqlCommand cmd1 = new SqlCommand("select RoleID from UserRole where ID='" + SelectedUser.UserId.ToString() + "'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            SelectedUser.UserId = Guid.Parse(dt.Rows[0]["ID"].ToString());
            SelectedUser.UserName = dt.Rows[0]["cuser"].ToString();
            SelectedUser.Password = dt.Rows[0]["cpass"].ToString();
            SelectedUser.EmailAddress = dt.Rows[0]["email"].ToString();
            SelectedUser.Mobile = dt.Rows[0]["mobile"].ToString();
            SelectedUser.DateOfBirth = dt.Rows[0]["dob"].ToString();

        }
        protected void Update_Click(object sender, EventArgs e)
        {
            // Security securityObject = new Security();
            // securityObject.encryptpass = cpass.Text;
            string strpass = encryptpass(cpass.Text);

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("Update c_details set cuser='" + SelectedUser.UserName + "',cpass=' +Security.encryptpass +',email='" + SelectedUser.EmailAddress + "',mobile='" + SelectedUser.Mobile + "',dob='" + SelectedUser.DateOfBirth + "' where ID= '" + SelectedUser.UserId.ToString() + "'", con);
            con.Open();
            cmd1.ExecuteNonQuery();
            cmd1.Parameters.Clear();
            SqlCommand cmd = new SqlCommand("Update UserRole set RoleID='" + RoleList.SelectedValue + "' where UserID= '" + SelectedUser.UserId.ToString() + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("~/UserManagement/UserManagement.aspx");
        }


        protected void Cancel_Update(object sender, EventArgs e)
        {
            Response.Redirect("~/UserManagement/UserManagement.aspx");
        }

        private void BindTextboxValues()
        {
            cuser.Text = SelectedUser.UserName;
            cpass.Text = SelectedUser.Password;
            email.Text = SelectedUser.EmailAddress;
            mobile.Text = SelectedUser.Mobile;
            dob.Text = SelectedUser.DateOfBirth;
        }

        private void BindSelectedUser()
        {
            SelectedUser.UserName = cuser.Text;
            SelectedUser.Password = cpass.Text;
            SelectedUser.EmailAddress = email.Text;
            SelectedUser.Mobile = mobile.Text;
            SelectedUser.DateOfBirth = dob.Text;
        }

        public string encryptpass(string password)
        {

            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            string msg = Convert.ToBase64String(encode);
            return msg;
        }
        public void GetDropDown()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select RoleID, Role_name from Roles", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            RoleList.DataSource = dt;
            RoleList.DataTextField = "Role_name";
            RoleList.DataValueField = "RoleID";
            RoleList.DataBind();
        }
       
    }
}