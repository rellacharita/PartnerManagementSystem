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
using System.IO;
using ISSI.PartnerManagementSystem.BusinessObjects;
namespace ISSI.PartnerManagementSystem.Web
{
    public partial class ModalPopup : System.Web.UI.Page
    {

        

        private PartnerDetails _partner = new PartnerDetails();
        public PartnerDetails SelectedPartner
        {
            set { _partner = value; 
            }
            get { 
                return _partner; 
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SelectedPartner.PartnerID = Guid.Parse(Request.QueryString["PartnerID"].ToString());
            if (!IsPostBack)
            {
                GetPartner();
                BindTextboxValues();
                
            }
            else
            {
                BindSelectedPartner();
            }
        }
       
        private void GetPartner()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select Partner_id,Partner_name,Contact_fname ,Contact_mname,Contact_lname,Contact_email,Contact_phno ,Partner_address_line1,Partner_address_line2,Partner_city,Partner_state,Partner_zipcode from Partner where Partner_id='"+SelectedPartner.PartnerID.ToString() +"'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
           
            SelectedPartner.PartnerID = Guid.Parse(dt.Rows[0]["Partner_id"].ToString());
            SelectedPartner.PartnerName = dt.Rows[0]["Partner_name"].ToString();
            SelectedPartner.ContactFirstName = dt.Rows[0]["Contact_fname"].ToString();
            SelectedPartner.ContactMiddleName = dt.Rows[0]["Contact_mname"].ToString();
            SelectedPartner.ContactLastName = dt.Rows[0]["Contact_lname"].ToString();
            SelectedPartner.ContactEmail = dt.Rows[0]["Contact_email"].ToString();
            SelectedPartner.ContactPhoneNumber = dt.Rows[0]["Contact_phno"].ToString();
            SelectedPartner.PartnerAddressLine1 = dt.Rows[0]["Partner_address_line1"].ToString();
            SelectedPartner.PartnerAddressLine2 = dt.Rows[0]["Partner_address_line2"].ToString();
            SelectedPartner.PartnerCity = dt.Rows[0]["Partner_city"].ToString();
            SelectedPartner.PartnerState = dt.Rows[0]["Partner_state"].ToString();
            SelectedPartner.PartnerZipcode = dt.Rows[0]["Partner_zipcode"].ToString();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {          
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString);
            SqlCommand cmd1 = new SqlCommand("Update Partner set Partner_name='" +SelectedPartner.PartnerName + "',Contact_fname='" + SelectedPartner.ContactFirstName + "',Contact_mname='" + SelectedPartner.ContactMiddleName + "',Contact_lname='" + SelectedPartner.ContactLastName + "',Contact_email='" + SelectedPartner.ContactEmail + "',Contact_phno='" + SelectedPartner.ContactPhoneNumber + "',Partner_address_line1='" + SelectedPartner.PartnerAddressLine1 + "',Partner_address_line2='"+SelectedPartner.PartnerAddressLine2+"',Partner_city='"+SelectedPartner.PartnerCity+"',Partner_state='"+SelectedPartner.PartnerState+"',Partner_zipcode='"+SelectedPartner.PartnerZipcode+"' where Partner_id= '"+SelectedPartner.PartnerID+"'", con);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
            Response.Redirect("~/PartnerManagement/Partner.aspx");
           
        }

        protected void btn_cancel(object sender, EventArgs e)
        {
            Response.Redirect("~/PartnerManagement/Partner.aspx");
     
       }

        private void BindTextboxValues()
        {
            Partner_name.Text = SelectedPartner.PartnerName;
            Contact_fname.Text = SelectedPartner.ContactFirstName;
            Contact_mname.Text = SelectedPartner.ContactMiddleName;
            Contact_lname.Text = SelectedPartner.ContactLastName;
            Contact_email.Text = SelectedPartner.ContactEmail;
            Contact_phno.Text = SelectedPartner.ContactPhoneNumber;
            Partner_address_line1.Text = SelectedPartner.PartnerAddressLine1;
            Partner_address_line2.Text = SelectedPartner.PartnerAddressLine2;
            Partner_city.Text = SelectedPartner.PartnerCity;
            Partner_state.Text = SelectedPartner.PartnerState;
            Partner_zipcode.Text = SelectedPartner.PartnerZipcode;

        }
        private void BindSelectedPartner()
        {
            SelectedPartner.PartnerName = Partner_name.Text;
            SelectedPartner.ContactFirstName = Contact_fname.Text;
            SelectedPartner.ContactMiddleName = Contact_mname.Text;
            SelectedPartner.ContactLastName = Contact_lname.Text;
            SelectedPartner.ContactEmail = Contact_email.Text;
            SelectedPartner.ContactPhoneNumber = Contact_phno.Text;
            SelectedPartner.PartnerAddressLine1 = Partner_address_line1.Text;
            SelectedPartner.PartnerAddressLine2 = Partner_address_line2.Text;
            SelectedPartner.PartnerCity = Partner_city.Text;
            SelectedPartner.PartnerState = Partner_state.Text;
            SelectedPartner.PartnerZipcode = Partner_zipcode.Text;
        }
    }
}