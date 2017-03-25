using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSI.PartnerManagementSystem.BusinessObjects
{
   public class Menu
    {
        private int _menuID;
        private string _menuName = string.Empty;
        private List<Rights> _rights = new List<Rights>();
        /// <summary>
        /// Gets or sets the menu identifier.
        /// </summary>
        /// <value>
        /// The menu identifier.
        /// </value>
        public int menuID
        {
            set { _menuID = value; }
            get { return _menuID; }
        }
        /// <summary>
        /// Gets or sets the name of the menu.
        /// </summary>
        /// <value>
        /// The name of the menu.
        /// </value>
        public string menuName
        {
            set { _menuName = value; }
            get { return _menuName; }
        }

        /// <summary>
        /// Gets or sets the rights.
        /// </summary>
        /// <value>
        /// The rights.
        /// </value>
        public List<Rights> Rights {
            set { _rights = value; }
            get { return _rights; }
        }
    }
}
