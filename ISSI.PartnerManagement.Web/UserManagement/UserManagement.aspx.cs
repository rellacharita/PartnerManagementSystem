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
using ISSI.PartnerManagement.Controller;


namespace ISSI.PartnerManagementSystem.Web
{
    public partial class UserManagement : System.Web.UI.Page
    {
      SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString);


        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            if (!this.IsPostBack)
            {

                BindGridView();
            }
        }
        private void BindGridView()
        {

           // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString);
           // SqlCommand cmd = new SqlCommand("select ID,cuser,cpass,email,mobile,dob from c_details", con);
          //  DataTable dt = new DataTable();
           // SqlDataAdapter da = new SqlDataAdapter(cmd);
           // da.Fill(dt);
            
            UserController userController = new UserController(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString.ToString());
             GridView1.DataSource = userController.getUser();
            GridView1.DataBind();
        }

       protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("~/UpdateUser.aspx?UserId=" + GridView1.Rows[index -1].Cells[0].Text);
            }
        }  
        protected void addUser_Click(object sender, EventArgs e)
        {
            User userObject = new User();
            userObject.UserId = Guid.NewGuid();
            userObject.UserName = user.Text;
            userObject.Password = pass.Text;
            userObject.EmailAddress = email.Text;
            userObject.Mobile = mobile.Text;
            userObject.DateOfBirth = dob.Text;
            SqlCommand cmd = new SqlCommand("Insert into c_details values('" + userObject.UserName + "','" + Security.encryptpass(pass.Text) + "','" + userObject.EmailAddress + "','" + Convert.ToInt32(userObject.Mobile) + "','" + Convert.ToDateTime(userObject.DateOfBirth).ToShortDateString() + "','" + userObject.UserId + "')", con);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
          
            SqlCommand cmd1 = new SqlCommand("Insert into UserRole values('"+DropDownList1.SelectedValue+ "', '"+userObject.UserId+"') ", con);
            cmd1.ExecuteNonQuery();
            
            con.Close();
            Response.Redirect("~/UserManagement/UserManagement.aspx");
        }

       
    }
}