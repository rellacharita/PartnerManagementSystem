using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISSI.PartnerManagementSystem.BusinessObjects;
using ISSI.PartnerManagementSystem.DataAccess;

namespace ISSI.PartnerManagement.Controller
{
   public class MenuController
    {
       private MenuData _menuData;
       public MenuController(string connectionString)
       {
           _menuData = new MenuData(connectionString);
       }
       public List<Menu> GetMenu()
       {
           return _menuData.GetMenu();
       }
    }
}
