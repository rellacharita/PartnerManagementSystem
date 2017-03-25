<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend.Master" AutoEventWireup="true" CodeBehind="MenuManagement.aspx.cs" Inherits="ISSI.PartnerManagementSystem.Web.MenuManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  
    <asp:CheckBoxList ID="MenuItems" runat="server"   DataTextField="MenuName" DataValueField="MenuID">
        <asp:ListItem>Partner Management</asp:ListItem>
        <asp:ListItem>Role Management</asp:ListItem>
        <asp:ListItem>User Management</asp:ListItem>
    </asp:CheckBoxList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString2 %>" SelectCommand="SELECT [MenuID], [MenuName] FROM [MenuLookupTable]"></asp:SqlDataSource>
        <asp:Button ID="SubmitMenu" runat="server" Text="Submit" OnClick="ConfirmMenu" />
            <asp:Button ID="CancelMenu" runat="server" Text="Cancel" OnClick="Cancel" />

</asp:Content>
