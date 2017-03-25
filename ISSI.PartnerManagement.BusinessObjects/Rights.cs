using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSI.PartnerManagementSystem.BusinessObjects
{
  public class Rights
    {
        private int _rightID;
        private string _rightName = string.Empty;
        public int rightID
        {
            set { _rightID = value; }
            get { return _rightID; }
        }
        public string rightName
        {
            set { _rightName = value; }
            get { return _rightName; }
        }
    }
}
