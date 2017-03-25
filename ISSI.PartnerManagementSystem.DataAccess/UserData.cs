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
    public class UserData
    {
        private String ConnectionString = string.Empty;
        public UserData(String connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<User> getUser() 
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select ID,cuser,cpass,email,mobile,dob from c_details", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            List<User> userDetails = new List<User>();

            foreach (DataRow row in dt.Rows)
            {
                User user = new User();
                user.UserId = Guid.Parse(row["ID"].ToString());
                user.UserName = row["cuser"].ToString();
               // Security.encryptpass(row["cpass"].ToString());
                user.Password = row["cpass"].ToString();
                user.EmailAddress = row["email"].ToString();
                user.Mobile = row["mobile"].ToString();
                user.DateOfBirth = row["dob"].ToString();
                userDetails.Add(user);
            }
            return userDetails ;

        }
    }
}
