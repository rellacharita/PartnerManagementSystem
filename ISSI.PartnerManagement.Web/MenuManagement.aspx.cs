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
    public partial class MenuManagement : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            GetLookupTable();
        }

        protected void ConfirmMenu(object sender, EventArgs e)
        {
            
          /*  string chkbox = "";
            for (int i = 0; i < MenuItems.Items.Count - 1; i++)
            {
                if (MenuItems.Items[i].Selected)
                {
                    if (chkbox == "")
                    {
                        chkbox = MenuItems.Items[i].ToString();

                    }
                    else
                    {
                        chkbox += "," + MenuItems.Items[i].ToString();
                    }
                }
            } */

            SqlCommand cmd = new SqlCommand("Insert into Roles(MenuID) values('@MenuID')", con);
            cmd.Parameters.AddWithValue("@MenuID", MenuItems.SelectedValue);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("~/RoleManagement/RoleManagement.aspx");


        }

        protected void Cancel(object sender, EventArgs e)
        {
            Response.Redirect("~/RoleManagement/RoleManagement.aspx");
        }

        public void GetLookupTable()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select MenuID, MenuName from MenuLookupTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            MenuItems.DataSource = dt;
            MenuItems.DataTextField = "MenuName";
            MenuItems.DataValueField = "MenuID";
            MenuItems.DataBind();
            MenuItems.SelectedIndex = -1;
        }
    }
}