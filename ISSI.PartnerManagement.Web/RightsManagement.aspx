<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend.Master" AutoEventWireup="true" CodeBehind="RightsManagement.aspx.cs" Inherits="ISSI.RightsManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        <asp:ListItem>Add</asp:ListItem>
        <asp:ListItem>Edit</asp:ListItem>
        <asp:ListItem>Delete</asp:ListItem>
    </asp:CheckBoxList>
        <asp:Button ID="SubmitRights" runat="server" Text="Submit" />


</asp:Content>
