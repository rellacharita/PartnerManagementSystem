using ISSI.PartnerManagementSystem.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ISSI.PartnerManagementSystem.DataAccess
{
    public class MenuData
    {
        private string ConnectionString = string.Empty;
        public MenuData(String connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<Menu> GetMenu()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select MenuID, MenuName from MenuLookupTable", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            List<Menu> menuDetails = new List<Menu>();
            
            foreach (DataRow row in dt.Rows)
            {
                Menu menu = new Menu();
                menu.menuID = Convert.ToInt16(row["MenuID"]);
                menu.menuName = row["MenuName"].ToString();
                menuDetails.Add(menu);
            }
            return menuDetails;
        } 
    }
}
