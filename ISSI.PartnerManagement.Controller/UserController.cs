using ISSI.PartnerManagementSystem.BusinessObjects;
using ISSI.PartnerManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ISSI.PartnerManagement.Controller
{
   public class UserController
    {
       private UserData _userData;

       public UserController(string connectionString)
       {
           _userData = new UserData(connectionString);
       }

       public List<User> getUser()
       {
           return _userData.getUser();
       }
    }
}
