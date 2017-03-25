using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISSI.PartnerManagementSystem.BusinessObjects
{

    public class User
    {
        private Guid _userID;
        private string _userName = string.Empty;
        private string _userPassword = string.Empty;
        private string _emailAddress = string.Empty;
        private string _mobile = string.Empty;
        private string _dateOfBirth = string.Empty;
 
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
        /// 
        /// </summary>
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