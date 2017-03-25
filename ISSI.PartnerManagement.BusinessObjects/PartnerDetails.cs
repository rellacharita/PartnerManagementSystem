using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISSI.PartnerManagementSystem.BusinessObjects
{
    /// <summary>
    /// 
    /// </summary>
    public class PartnerDetails
    {
        /// <summary>
        /// The partner identifier
        /// </summary>
        private Guid _partnerID;
        /// <summary>
        /// The partner name
        /// </summary>
        private string _partnerName = string.Empty;
        /// <summary>
        /// The contact first name
        /// </summary>
        private string _contactFirstName = string.Empty;
        /// <summary>
        /// The contact middle name
        /// </summary>
        private string _contactMiddleName = string.Empty;
        /// <summary>
        /// The contact last name
        /// </summary>
        private string _contactLastName = string.Empty;
        /// <summary>
        /// The contact email
        /// </summary>
        private string _contactEmail = string.Empty;
        /// <summary>
        /// The contact phone number
        /// </summary>
        private string _contactPhoneNumber = string.Empty;
        /// <summary>
        /// The partner address line1
        /// </summary>
        private string _partnerAddressLine1 = string.Empty;
        /// <summary>
        /// The partner address line2
        /// </summary>
        private string _partnerAddressLine2 = string.Empty;
        /// <summary>
        /// The partner city
        /// </summary>
        private string _partnerCity = string.Empty;
        /// <summary>
        /// The partner state
        /// </summary>
        private string _partnerState = string.Empty;
        /// <summary>
        /// The partner zipcode
        /// </summary>
        private string _partnerZipcode = string.Empty;

        /// <summary>
        /// Gets or sets the partner identifier.
        /// </summary>
        /// <value>
        /// The partner identifier.
        /// </value>
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

        /// <summary>
        /// Gets or sets the name of the partner.
        /// </summary>
        /// <value>
        /// The name of the partner.
        /// </value>
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

        /// <summary>
        /// Gets or sets the first name of the contact.
        /// </summary>
        /// <value>
        /// The first name of the contact.
        /// </value>
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

        /// <summary>
        /// Gets or sets the name of the contact middle.
        /// </summary>
        /// <value>
        /// The name of the contact middle.
        /// </value>
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

        /// <summary>
        /// Gets or sets the last name of the contact.
        /// </summary>
        /// <value>
        /// The last name of the contact.
        /// </value>
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

        /// <summary>
        /// Gets or sets the contact email.
        /// </summary>
        /// <value>
        /// The contact email.
        /// </value>
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

        /// <summary>
        /// Gets or sets the contact phone number.
        /// </summary>
        /// <value>
        /// The contact phone number.
        /// </value>
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

        /// <summary>
        /// Gets or sets the partner address line1.
        /// </summary>
        /// <value>
        /// The partner address line1.
        /// </value>
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

        /// <summary>
        /// Gets or sets the partner address line2.
        /// </summary>
        /// <value>
        /// The partner address line2.
        /// </value>
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

        /// <summary>
        /// Gets or sets the partner city.
        /// </summary>
        /// <value>
        /// The partner city.
        /// </value>
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

        /// <summary>
        /// Gets or sets the state of the partner.
        /// </summary>
        /// <value>
        /// The state of the partner.
        /// </value>
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

        /// <summary>
        /// Gets or sets the partner zipcode.
        /// </summary>
        /// <value>
        /// The partner zipcode.
        /// </value>
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