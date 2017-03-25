<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ISSI.PartnerManagementSystem.Web.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
            text-align: right;
            width: 668px;
        }
        .auto-style6 {
            width: 668px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>New Registration</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style6">User Name:</td>
                <td>
                    <asp:TextBox ID="TextBoxUN" runat="server" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUN" ErrorMessage="Enter User Name" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBoxUN" Display="Dynamic" ErrorMessage="Must be 6-8 characters" ForeColor="Red" ValidationExpression="[a-zA-Z]{6,10}"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Password:</td>
                <td>
                    <asp:TextBox ID="TextBoxPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPass" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBoxPass" Display="Dynamic" ErrorMessage="must be 8-10 charcters with special characters" ForeColor="Red" ValidationExpression=".*[@#$%^&amp;*/].*1234567890"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Confirm Password:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxCPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxCPass" ErrorMessage="Repeat Password" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPass" ControlToValidate="TextBoxCPass" ErrorMessage="Re-enter same password" ForeColor="Red" Display="Dynamic"></asp:CompareValidator>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style6">Email:</td>
                <td>
                    <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Enter Email" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Enter Valid Address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Mobile:</td>
                <td>
                    <asp:TextBox ID="TextBoxMob" runat="server" TextMode="Phone" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxMob" ErrorMessage="Enter Mobile" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Date of Birth:</td>
                <td>
                    <asp:TextBox ID="TextBoxDOB" runat="server" TextMode="Date" Width="180px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxDOB" ErrorMessage="Enter Date of Birth" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                    <input id="Reset1" type="reset" value="reset" /></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
