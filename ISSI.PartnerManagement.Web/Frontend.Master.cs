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

namespace ISSI.PartnerManagementSystem.Web
{
    public partial class Frontend : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userName"] != null)
            {
                welcomeUser.Text = string.Format("Welcome{0}", Session["userName"].ToString());
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {

            Response.Redirect("log.aspx");
        }

        protected void Menu1_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            Menu menu = sender as Menu;
            SiteMapNode mapNode = e.Item.DataItem as SiteMapNode;

            if (menu != null && mapNode != null)
            {
                MenuItem itemToRemove = menu.FindItem(mapNode.Title);
                if (Session["userRole"] != null)
                {
                    if (Session["userRole"].ToString() == "Manager")
                    {
                        if (mapNode.Title == "Partner Management")
                        {
                            MenuItem parent = e.Item.Parent;
                            if (parent != null)
                           {
                                parent.ChildItems.Remove(e.Item);
                            }
                            else
                            {
                                menu.Items.Remove(e.Item);
                            }
                        }
                    }
                    else {
                        if (mapNode.Title == "User Management")
                        {
                            MenuItem parent = e.Item.Parent;
                            if (parent != null)
                            {
                                parent.ChildItems.Remove(e.Item);
                            }
                            else
                            {
                                menu.Items.Remove(e.Item);
                            }
                        }
                    }
                }
            }

        }
    }
}