using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSI.PartnerManagementSystem.BusinessObjects
{
  public class Role
    {
      private Guid _roleID;
      private string _roleName = string.Empty;
      public Guid roleID
      {
          set
          {
              _roleID = value;
          }

          get
          {
              return _roleID;
          }
      }

      public string roleName
      {
          set
          {
              _roleName = value;
          }
          get
          {
              return _roleName;
          }
      }
      



    }
}
