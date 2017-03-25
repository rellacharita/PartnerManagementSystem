using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISSI.PartnerManagementSystem.BusinessObjects
{

    /// <summary>
    /// 
    /// </summary>
    public class User
    {
        /// <summary>
        /// The user identifier
        /// </summary>
        private Guid _userID;
        /// <summary>
        /// The user name
        /// </summary>
        private string _userName = string.Empty;
        /// <summary>
        /// The user password
        /// </summary>
        private string _userPassword = string.Empty;
        /// <summary>
        /// The email address
        /// </summary>
        private string _emailAddress = string.Empty;
        /// <summary>
        /// The mobile
        /// </summary>
        private string _mobile = string.Empty;
        /// <summary>
        /// The date of birth
        /// </summary>
        private string _dateOfBirth = string.Empty;

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public Guid UserId
        {
            set {
                _userID = value;
            }
            get
            {
                return _userID;
            }
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName
        {
            get
            {
                return _userName;

            }
            set
            {
                _userName = value;
            }
        }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password
        {
            get
            {
                return _userPassword;
            }
            set
            {
                _userPassword = value;
            }
        }
        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>
        /// The email address.
        /// </value>
        public string EmailAddress
        {
            get
            {
                return _emailAddress;

            }
            set
            {
                _emailAddress = value;
            }
        }
        /// <summary>
        /// Gets or sets the mobile.
        /// </summary>
        /// <value>
        /// The mobile.
        /// </value>
        public string Mobile
        {
            get
            {
                return _mobile;

            }
            set
            {
                _mobile = value;
            }
        }
        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        /// <value>
        /// The date of birth.
        /// </value>
        public string DateOfBirth
        {
            get
            {
                return _dateOfBirth;

            }
            set
            {
                _dateOfBirth = value;
            }
        }
    }
}