using ISSI.PartnerManagementSystem.BusinessObjects;
using ISSI.PartnerManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSI.PartnerManagement.Controller
{
    public class PartnerController
    {
        private PartnerData _partnerData;
        //private string _connectionString = string.Empty;

       
        //public String ConnectionString {
        //    get { return _connectionString; }
        //    set { _connectionString = value; }
        //}

        public PartnerController(string connectionString) 
        {
            _partnerData = new PartnerData(connectionString);
        }

        public List<PartnerDetails> GetPartners() 
        {
            return _partnerData.GetPartners();
        }
    }
}
