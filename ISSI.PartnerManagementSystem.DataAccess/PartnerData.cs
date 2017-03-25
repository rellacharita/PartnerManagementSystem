using ISSI.PartnerManagementSystem.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ISSI.PartnerManagementSystem.DataAccess
{
    public class PartnerData
    {
        private String ConnectionString = string.Empty;

        public PartnerData(String connectionString) 
        {
            ConnectionString = connectionString;
        }

 

        public List<PartnerDetails> GetPartners() {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select Partner_id,Partner_name,Contact_fname,Contact_mname,Contact_lname,Contact_email,Contact_phno,Partner_address_line1,Partner_address_line2,Partner_city,Partner_state,Partner_zipcode from Partner", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            List<PartnerDetails> partnerDetails = new List<PartnerDetails>();
            foreach (DataRow row in dt.Rows) {
                PartnerDetails partnerDetail = new PartnerDetails();
                partnerDetail.PartnerID = Guid.Parse(row["Partner_id"].ToString());
                partnerDetail.PartnerName = row["Partner_name"].ToString();
                partnerDetail.ContactFirstName = row["Contact_fname"].ToString();
                partnerDetail.ContactMiddleName = row["Contact_mname"].ToString();
                partnerDetail.ContactLastName = row["Contact_lname"].ToString();
                partnerDetail.ContactEmail = row["Contact_email"].ToString();
                partnerDetail.ContactPhoneNumber = row["Contact_phno"].ToString();
                partnerDetail.PartnerAddressLine1 = row["Partner_address_line1"].ToString();
                partnerDetail.PartnerAddressLine2 = row["Partner_address_line2"].ToString();
                partnerDetail.PartnerCity = row["Partner_city"].ToString();
                partnerDetail.PartnerState = row["Partner_state"].ToString();
                partnerDetail.PartnerZipcode=row["Partner_zipcode"].ToString();
                partnerDetails.Add(partnerDetail);
            }

            return partnerDetails;
        }
    }
}
