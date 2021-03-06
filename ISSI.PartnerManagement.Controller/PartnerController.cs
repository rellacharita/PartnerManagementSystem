﻿using ISSI.PartnerManagementSystem.BusinessObjects;
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
        /// <summary>
        /// The partner data
        /// </summary>
        private PartnerData _partnerData;
        //private string _connectionString = string.Empty;

       
        //public String ConnectionString {
        //    get { return _connectionString; }
        //    set { _connectionString = value; }
        //}

        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerController"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public PartnerController(string connectionString) 
        {
            _partnerData = new PartnerData(connectionString);
        }

        /// <summary>
        /// Gets the partners.
        /// </summary>
        /// <returns></returns>
        public List<PartnerDetails> GetPartners() 
        {
            return _partnerData.GetPartners();
        }
    }
}
