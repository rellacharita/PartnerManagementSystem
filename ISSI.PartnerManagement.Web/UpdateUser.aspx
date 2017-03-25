<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="ISSI.PartnerManagementSystem.Web.UpdateUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- <link href="styles.css" rel="stylesheet" type="text/css" /> -->

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 1444px;
        }

        .auto-style3 {
            width: 710px;
            text-align: right;
        }

        .auto-style4 {
            width: 710px;
            text-align: right;
            height: 26px;
        }

        .auto-style5 {
            height: 26px;
        }

        .auto-style6 {
            width: 710px;
            text-align: right;
            height: 29px;
        }

        .auto-style7 {
            height: 29px;
        }
        .hidden{
    display:none;
}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Update User</h2>
    <table class="auto-style1">
        <tr>
            <td colspan="2">User Details</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="ID" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Cuser:</td>
            <td>
                <asp:TextBox ID="cuser" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Cpass:</td>
            <td class="auto-style7">
                <asp:TextBox ID="cpass" runat="server" TextMode="Password"></asp:TextBox>

                <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Alert! You're updating PASSWORD" CssClass="hidden"></asp:Label>

            </td>
        </tr>
        <tr>
            <td class="auto-style3">Email:</td>
            <td>
                <asp:TextBox ID="email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Mobile:</td>
            <td>
                <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Date of Birth:</td>
            <td>
                <asp:TextBox ID="dob" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Role:</td>
            <td>
                <asp:DropDownList ID="RoleList" runat="server" DataTextField="Role_name" DataValueField="RoleID">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString2 %>" SelectCommand="SELECT [RoleID], [Role_name] FROM [Roles]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString2 %>" SelectCommand="SELECT [Role_name] FROM [Roles]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style5">
                <asp:Button ID="Button3" runat="server" OnClick="Update_Click" Text="Update" />
                <asp:Button ID="Button5" runat="server" OnClick="Cancel_Update" Text="Cancel" />
            </td>
        </tr>
    </table>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#" + "<%=cpass.ClientID %>").change(function () {
                $("#" + "<%=Label1.ClientID %>").show();
            });

        });

    </script>
    


</asp:Content>
