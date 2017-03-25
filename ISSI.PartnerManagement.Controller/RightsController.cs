using ISSI.PartnerManagementSystem.BusinessObjects;
using ISSI.PartnerManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSI.PartnerManagement.Controller
{
   public class RightsController
    {
       private RightsData _rightsData;
       /// <summary>
       /// Initializes a new instance of the <see cref="RightsController"/> class.
       /// </summary>
       /// <param name="connectionString">The connection string.</param>
       public RightsController(string connectionString)
       {
           _rightsData = new RightsData(connectionString);
       }
       /// <summary>
       /// Gets the rights.
       /// </summary>
       /// <returns></returns>
       public List<Rights> GetRights()
       {
           return _rightsData.GetRights();
       }
    }
}
