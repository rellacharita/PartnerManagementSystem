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
    public partial class UpdateRole : System.Web.UI.Page
    {
        private User _role = new User();
        public User SelectedRole
        {
            set { _role = value; }
            get { return _role; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            SelectedRole.UserId = Guid.Parse(Request.QueryString["RoleID"].ToString());
            if (!IsPostBack)
            {
                GetRole();
                BindTextboxValues();

            }
            else
            {
                BindSelectedRole();
            }
        }

        private void GetRole()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select RoleID,Role_name from Roles where RoleID= '" + SelectedRole.UserId.ToString() + "'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            SelectedRole.UserId = Guid.Parse(dt.Rows[0]["RoleID"].ToString());
            SelectedRole.UserName = dt.Rows[0]["Role_name"].ToString();
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString);
            SqlCommand cmd= new SqlCommand("Update Roles set Role_name ='"+SelectedRole.UserName+"' where RoleID= '"+ SelectedRole.UserId.ToString()+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("RoleManagement.aspx");
        }


        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("RoleManagement.aspx");
        }
        private void BindTextboxValues()
        {
            RoleName.Text = SelectedRole.UserName;
        }
        private void BindSelectedRole()
        {
            SelectedRole.UserName = RoleName.Text;
        }
       
    }
}