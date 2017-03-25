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

       /// <summary>
       /// Initializes a new instance of the <see cref="UserController"/> class.
       /// </summary>
       /// <param name="connectionString">The connection string.</param>
       public UserController(string connectionString)
       {
           _userData = new UserData(connectionString);
       }

       /// <summary>
       /// Gets the user.
       /// </summary>
       /// <returns></returns>
       public List<User> getUser()
       {
           return _userData.getUser();
       }
    }
}
