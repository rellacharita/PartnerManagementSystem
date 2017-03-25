<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend.Master" AutoEventWireup="true" CodeBehind="UpdateRole.aspx.cs" Inherits="ISSI.PartnerManagementSystem.Web.UpdateRole" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <table class="auto-style1">
        <tr>
            <td class="auto-style3">Update Role:</td>
            <td class="auto-style2">
                <asp:TextBox ID="RoleName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Update" runat="server" OnClick="Update_Click" Text="Update" />
                <asp:Button ID="Cancel" runat="server" Text="Cancel" OnClick="Cancel_Click" />
            </td>
        </tr>
    </table>


</asp:Content>
