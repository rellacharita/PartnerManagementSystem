using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;
using System.Security.Cryptography;
namespace ISSI.PartnerManagementSystem.Web
{
    public partial class log : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //on page load hide the welcome tilte and the error text
            welcomeTitle.Visible = false;
            Error.Visible = false;
        }

        public string encryptpass(string password)
        {

            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            string msg = Convert.ToBase64String(encode);
            return msg;
        }



        /*
         * @param sender
         * @param e
         * 
         * This method gets called on the click/submit event of login button.
         * It validates user credentials and shows 'Welcome message' for successful login 
         * and shows error messages in case of invalid credentials
         * */
        protected void Login_Button_Handler(object sender, EventArgs e)
        {
            string strpass = encryptpass(Password.Value); //1.encrypt password
            Error.Visible = false;
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CustomerConnectionString2"].ConnectionString);
            sqlConnection.Open();
            string userName = UserName.Value;// value of user name input
            bool userExists = this.checkIfUserExists(userName, sqlConnection);
            string userRole = this.getUserRole(userName, sqlConnection);
            //  check if user exists
            if (userExists)
            {
                bool isValidPassword = this.validatePassword(userName, strpass, sqlConnection);
                if (isValidPassword)
                {
                    loginForm.Visible = false;
                    welcomeTitle.Visible = true;
                    Session["userName"] = UserName.Value;
                    Session["userRole"] = userRole;
                    Response.Redirect("~/PartnerManagement/Partner.aspx");
                }
                else
                {
                    Error.Visible = true;
                    Error.InnerHtml = "Incorrect password";
                }
            }
            else
            {
                sqlConnection.Close();
                Error.Visible = true;
                Error.InnerHtml = "No user exits with the login " + userName;
            }
           
        }

        private string getUserRole(string userName, SqlConnection sqlConnection)
        {
          //  string userRole = (sqlCommand.ExecuteScalar().ToString());
           // string userRole;
            string userRoleQuery = "select r.role_name from dbo.Roles r left join dbo.UserRole ur on (r.RoleID = ur.RoleID) left join dbo.c_details u on (ur.UserID=u.ID) where u.cuser='k'";

            SqlCommand sqlCommand = new SqlCommand(userRoleQuery, sqlConnection);
           string userRole = (sqlCommand.ExecuteScalar().ToString());
            return userRole;
        }

        /*
         * @param userName
         * @param userEnteredPassword
         * @param sqlConnection
         * 
         * This function compares user entered password with the password in db and returns true if both are same otherwise it returns false.
         * */
        private bool validatePassword(String userName, String userEnteredPassword, SqlConnection sqlConnection)
        {
            SqlCommand passCom = new SqlCommand(this.getPasswordQuery(userName), sqlConnection);
            // string strpass = Decryptpass(Password.Value); 
            string passwordInDB = passCom.ExecuteScalar().ToString();
            return passwordInDB == userEnteredPassword;
        }
        /*
         * @param userName
         * This method returns true if there is an user entry in the DB for the passed userName
         * 
         * */
        private bool checkIfUserExists(string userName, SqlConnection sqlConnection)
        {
            SqlCommand sqlCommand = new SqlCommand(this.getUserValidationQuery(userName), sqlConnection);
            int noOfUserRecords = Convert.ToInt32(sqlCommand.ExecuteScalar().ToString());
            return noOfUserRecords == 1;
        }

        /*
         * @param userName
         * This method returns the query to retrive password for the passed userName
         * */
        private string getPasswordQuery(string userName)
        {
            return "select cpass from c_details where cuser='" + userName + "' ";
        }

        /*
         * @param userName
         * This method returns the query to validate the passed userName
         * */
        private string getUserValidationQuery(string userName)
        {
            return "select count(*) from c_details where cuser='" + userName + "'";
        }


    }
}
