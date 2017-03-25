using ISSI.PartnerManagementSystem.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ISSI.PartnerManagementSystem.DataAccess
{
   public class RightsData
    {
        private string ConnectionString = string.Empty;
        public RightsData(String connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<Rights> GetRights()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select RightID, RightName from RightsLookupTable", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            List<Rights> rightDetails = new List<Rights>();
            
            foreach (DataRow row in dt.Rows)
            {
                Rights rights = new Rights();
                rights.rightID = Convert.ToInt16(row["RightID"]);
                rights.rightName = row["RightName"].ToString();
                rightDetails.Add(rights);
            }
            return rightDetails;
        } 
    }
}
