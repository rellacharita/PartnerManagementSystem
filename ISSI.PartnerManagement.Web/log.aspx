<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="log.aspx.cs" Inherits="ISSI.PartnerManagementSystem.Web.log" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> LOGIN </title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-alpha.6/css/bootstrap.min.css" />
   <style>
       .form-signin {
          max-width: 380px;
          padding: 15px 35px 45px;
          margin: 0 auto;
          background-color: #eee;
          border-radius:15px;
          border: 1px solid rgba(0, 0, 0, 0.1);
        }
       .white-bg{
           background-color:#fff;
           border:none;
       }
       .form-signin input{
           margin-bottom: 5px;
       }

       .auto-style1 {
           font-size: large;
       }
      
       
   </style>
    <!-- Latest compiled and minified CSS -->

    
<!-- jQuery library -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    
<!-- Latest compiled JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>

<body>
     
          <div class="wrapper">
            <div class="form-signin white-bg">
                <h2 id="welcomeTitle" runat="server"> Welcome&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h2>
            </div>
            <form class="form-signin" id="loginForm" runat="server">       
            
                <div class="img-container">
                    <img src="http://www.sumtotalsystems.com/dist/img/partner_logos/issi.png" alt="Logo" class="logo" width="300" height="200"/>
                </div><br />
              <input type="text" id="UserName" runat="server" class="form-control" name="username" placeholder="User Name" required="" autofocus="autofocus" />

                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="UserName" runat="server" ErrorMessage="Enter User Name" ForeColor="Red"></asp:RequiredFieldValidator>   
              <input id="Password" runat="server" type="password" class="form-control" name="password" placeholder="Password" required=""/>  
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="Password" runat="server" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>    
              <label class="checkbox">
                <input type="checkbox" value="remember-me" id="rememberMe" name="rememberMe"/> Remember me
              </label>
              <asp:Button ID="Button1" runat="server" class="btn btn-lg btn-primary btn-block" OnClick="Login_Button_Handler" Text="Login" BackColor="#990000" BorderColor="#990000" />
                
             
              <div id="Error" class="text-danger" runat="server"> </div>
            </form>
             
            
                
          </div>
         
   </body>
</html>