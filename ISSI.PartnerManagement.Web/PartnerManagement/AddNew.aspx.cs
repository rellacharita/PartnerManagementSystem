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
namespace ISSI.PartnerManagementSystem.Web
{
    public partial class AddNew : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void cancelUpdate(object sender, EventArgs e)
        {
            Response.Redirect("~/PartnerManagement/Partner.aspx");
        }


        protected void OK_Click(object sender, EventArgs e)
        {
            PartnerDetails partnerObject = new PartnerDetails();
            partnerObject.PartnerID = Guid.NewGuid();
            partnerObject.PartnerName = Partner_name.Text;
            partnerObject.ContactFirstName = Contact_fname.Text;
            partnerObject.ContactMiddleName = Contact_mname.Text;
            partnerObject.ContactLastName = Contact_lname.Text;
            partnerObject.ContactEmail = Contact_email.Text;
            partnerObject.ContactPhoneNumber = Contact_phno.Text;
            partnerObject.PartnerAddressLine1 = Partner_address_line1.Text;
            partnerObject.PartnerAddressLine2 = Partner_address_line2.Text;
            partnerObject.PartnerCity = Partner_city.Text;
            partnerObject.PartnerState = Partner_state.Text;
            partnerObject.PartnerZipcode = Partner_zipcode.Text;

            SqlCommand cmd = new SqlCommand("Insert into Partner values('" + partnerObject.PartnerID + "','" + partnerObject.PartnerName + "','" + partnerObject.ContactFirstName + "','" + partnerObject.ContactMiddleName + "','" + partnerObject.ContactLastName + "','" + partnerObject.ContactEmail + "'," + partnerObject.ContactPhoneNumber + ",'" + partnerObject.PartnerAddressLine1 + "','" + partnerObject.PartnerAddressLine2 + "','" + partnerObject.PartnerCity + "','" +partnerObject.PartnerState + "','" +partnerObject.PartnerZipcode+ "')", con);
            
            cmd.ExecuteNonQuery();
            con.Close();
            Panel1.Visible = true;          
            Response.Redirect("~/PartnerManagement/Partner.aspx");
        }
    }
}