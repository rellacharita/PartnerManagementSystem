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

        public int menuID
        {
            set { _menuID = value; }
            get { return _menuID; }
        }
        public string menuName
        {
            set { _menuName = value; }
            get { return _menuName; }
        }
    }
}
