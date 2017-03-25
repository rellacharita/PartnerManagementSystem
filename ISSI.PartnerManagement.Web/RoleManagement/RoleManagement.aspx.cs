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
using ISSI.PartnerManagementSystem.BusinessObjects;
using ISSI.PartnerManagement.Controller;

namespace ISSI.PartnerManagementSystem.Web
{
    public partial class RoleManagement : System.Web.UI.Page
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

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString);
            //SqlCommand cmd = new SqlCommand("select RoleID,Role_name from Roles", con);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
           // da.Fill(dt);
            RoleController roleController = new RoleController(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString.ToString());
            GridView1.DataSource = roleController.GetRoles();
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("~/UpdateRole.aspx?roleID=" + GridView1.Rows[index - 1].Cells[0].Text);
            }
            if (e.CommandName == "MenuButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("~/MenuManagement.aspx?roleID=" + GridView1.Rows[index - 1].Cells[0].Text);
            }
            if (e.CommandName == "RightsButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("~/RightsManagement.aspx?roleID=" + GridView1.Rows[index - 1].Cells[0].Text);
            }
        }

     

        protected void Confirm_new(object sender, EventArgs e)
        {
            Role roleObject = new Role();
            roleObject.roleID = Guid.NewGuid();
            roleObject.roleName = Role_name.Text;
           
            SqlCommand cmd = new SqlCommand("Insert into Roles values('" + roleObject.roleID + "','" + roleObject.roleName + "')", con);
            cmd.ExecuteNonQuery();
           // cmd.Parameters.Clear();
            con.Close();
            Response.Redirect("~/RoleManagement/RoleManagement.aspx");

        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}