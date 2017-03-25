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
       /// <summary>
       /// Initializes a new instance of the <see cref="RoleController"/> class.
       /// </summary>
       /// <param name="connectionString">The connection string.</param>
       public RoleController(string connectionString)
       {
           _roleData = new RoleData(connectionString);

       }

       /// <summary>
       /// Gets the roles.
       /// </summary>
       /// <returns></returns>
       public List<Role> GetRoles()
       {
           return _roleData.GetRoles();
       }
    }
}
