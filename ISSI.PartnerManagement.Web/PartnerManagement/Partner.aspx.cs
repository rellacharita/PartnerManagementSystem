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
using ISSI.PartnerManagement.Controller;
namespace ISSI.PartnerManagementSystem.Web
{
    public partial class Partner : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!this.IsPostBack)
            {

                BindGridView();
            }
        }
        private void BindGridView()
        {

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString);
            //SqlCommand cmd = new SqlCommand("select * from Partner", con);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            PartnerController partnerController = new PartnerController(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString.ToString());
            GridView1.DataSource = partnerController.GetPartners();
            GridView1.DataBind();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("~/PartnerManagement/ModalPopup.aspx?PartnerID=" + GridView1.Rows[index - 1].Cells[0].Text);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PartnerManagement/AddNew.aspx");

        }
    }
}