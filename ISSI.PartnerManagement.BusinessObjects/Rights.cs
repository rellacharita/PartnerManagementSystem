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
        /// <summary>
        /// Gets or sets the right identifier.
        /// </summary>
        /// <value>
        /// The right identifier.
        /// </value>
        public int rightID
        {
            set { _rightID = value; }
            get { return _rightID; }
        }
        /// <summary>
        /// Gets or sets the name of the right.
        /// </summary>
        /// <value>
        /// The name of the right.
        /// </value>
        public string rightName
        {
            set { _rightName = value; }
            get { return _rightName; }
        }
    }
}
