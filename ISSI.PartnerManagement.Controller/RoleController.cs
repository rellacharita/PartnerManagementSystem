using ISSI.PartnerManagementSystem.BusinessObjects;
using ISSI.PartnerManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSI.PartnerManagement.Controller
{
   public class RoleController
    {
       private RoleData _roleData;
       public RoleController(string connectionString)
       {
           _roleData = new RoleData(connectionString);

       }

       public List<Role> GetRoles()
       {
           return _roleData.GetRoles();
       }
    }
}
