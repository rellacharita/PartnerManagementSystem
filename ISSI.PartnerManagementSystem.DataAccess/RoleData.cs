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
    public class RoleData
    {
        private String ConnectionString = string.Empty;

        public RoleData(String connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<Role> GetRoles()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select RoleID, Role_name from Roles", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            List<Role> roleDetails = new List<Role>();

            foreach (DataRow row in dt.Rows)
            {
                Role role = new Role();
                role.roleID = Guid.Parse(row["RoleID"].ToString());
                role.roleName = row["Role_name"].ToString();               
                roleDetails.Add(role);
            }
            return roleDetails;
        }
    }
}