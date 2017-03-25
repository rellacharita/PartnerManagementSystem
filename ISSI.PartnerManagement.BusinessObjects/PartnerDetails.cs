using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISSI.PartnerManagementSystem.BusinessObjects
{
    public class PartnerDetails
    {
        private Guid _partnerID;
        private string _partnerName = string.Empty;
        private string _contactFirstName = string.Empty;
        private string _contactMiddleName = string.Empty;
        private string _contactLastName = string.Empty;
        private string _contactEmail = string.Empty;
        private string _contactPhoneNumber = string.Empty;
        private string _partnerAddressLine1 = string.Empty;
        private string _partnerAddressLine2 = string.Empty;
        private string _partnerCity = string.Empty;
        private string _partnerState = string.Empty;
        private string _partnerZipcode = string.Empty;

        public Guid PartnerID
        {
            set
            {
                _partnerID = value;
            }

            get
            {
                return _partnerID;
            }
        }

        public string PartnerName
        {
            set
            {
                _partnerName = value;
            }
            get
            {
                return _partnerName;
            }
        }

        public string ContactFirstName
        {
            set
            {
                _contactFirstName = value;
            }
            get
            {
                return _contactFirstName;
            }
        }

        public string ContactMiddleName
        {
            set
            {
                _contactMiddleName = value;

            }
            get
            {
                return _contactMiddleName;
            }
        }

        public string ContactLastName
        {
            set
            {
                _contactLastName = value;
            }
            get
            {
                return _contactLastName;
            }
        }

        public string ContactEmail
        {
            set
            {
                _contactEmail = value;
            }
            get
            {
                return _contactEmail;
            }
        }

        public string ContactPhoneNumber
        {
            set
            {
                _contactPhoneNumber = value;
            }
            get
            {
                return _contactPhoneNumber;
            }
        }

        public string PartnerAddressLine1
        {
            set
            {
                _partnerAddressLine1 = value;
            }
            get
            {
                return _partnerAddressLine1;
            }
        }

        public string PartnerAddressLine2
        {
            set
            {
                _partnerAddressLine2 = value;
            }
            get
            {
                return _partnerAddressLine2;
            }
        }

        public string PartnerCity
        {
            set
            {
                _partnerCity = value;
            }
            get
            {
                return _partnerCity;
            }
        }

        public string PartnerState
        {
            set
            {
                _partnerState = value;
            }
            get
            {
                return _partnerState;
            }
        }

        public string PartnerZipcode
        {
            set
            {
                _partnerZipcode = value;
            }
            get
            {
                return _partnerZipcode;
            }
        }
    }
}