using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSI.PartnerManagementSystem.BusinessObjects
{
    /// <summary>
    /// 
    /// </summary>
  public class Role
    {
        /// <summary>
        /// The role identifier
        /// </summary>
      private Guid _roleID;
      /// <summary>
      /// The role name
      /// </summary>
      private string _roleName = string.Empty;
      /// <summary>
      /// The menus
      /// </summary>
      private List<Menu> _menus = new List<Menu>();
      /// <summary>
      /// Gets or sets the role identifier.
      /// </summary>
      /// <value>
      /// The role identifier.
      /// </value>
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

      /// <summary>
      /// Gets or sets the name of the role.
      /// </summary>
      /// <value>
      /// The name of the role.
      /// </value>
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

      /// <summary>
      /// Gets or sets the menus.
      /// </summary>
      /// <value>
      /// The menus.
      /// </value>
      public List<Menu> Menus {
          set { _menus = value; }
          get { return _menus; }
      }


    }
}
