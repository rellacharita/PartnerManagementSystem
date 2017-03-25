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
       public RightsController(string connectionString)
       {
           _rightsData = new RightsData(connectionString);
       }
       public List<Rights> GetRights()
       {
           return _rightsData.GetRights();
       }
    }
}
