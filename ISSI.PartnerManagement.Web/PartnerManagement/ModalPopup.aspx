<%@ Page Title="Update Details" Language="C#" MasterPageFile="~/Frontend.Master" AutoEventWireup="true" CodeBehind="ModalPopup.aspx.cs" Inherits="ISSI.PartnerManagementSystem.Web.ModalPopup" %>
<%@ Register Assembly="AjaxControlToolkit"
	Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 33px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
   <h2>Update Information</h2>
    <asp:Panel ID="Panel1" runat="server">
        <table>
	<tr>
	<td colspan="2"  >Partner Details</td>
	</tr>
	<tr>
		<td>
		<asp:Label ID="Partner_id" runat="server"></asp:Label>
		</td>
	</tr>
	<tr>
		<td>
		Partner Name:
		</td>
		<td>
		<asp:TextBox ID="Partner_name" runat="server" Font-Bold="False"/>
		</td>
	</tr>
	<tr>
		<td>
		 Contact First Name:
		</td>
		<td>
		<asp:TextBox ID="Contact_fname" runat="server"/>
		</td>
	</tr>
	<tr>
		<td>
		Contact Middle Name:
		</td>
		<td>
		<asp:TextBox ID="Contact_mname" runat="server"/>
		</td>
	</tr>
	<tr>
		<td>
		Contact Last Name:
		</td>
		<td>
		<asp:TextBox ID="Contact_lname" runat="server"/>
		</td>
	</tr>
	<tr>
		<td>
		Contact Email:
		</td>
		<td>
		<asp:TextBox ID="Contact_email" runat="server"/>
		</td>
	</tr>
    <tr>
		<td>
		Contact Phone Number:
		</td>
		<td>
		<asp:TextBox ID="Contact_phno" runat="server"/>
		</td>
	</tr>
    <tr>
		<td>
		Partner Address Line 1:
		</td>
		<td>
		<asp:TextBox ID="Partner_address_line1" runat="server"/>
		</td>
	</tr>
    <tr>
		<td>
        Partner Address Line 2:
	    </td>
		<td>
		<asp:TextBox ID="Partner_address_line2" runat="server"/>
		</td>
	</tr>
    <tr>
		<td>
		City:
		</td>
		<td>
		<asp:TextBox ID="Partner_city" runat="server"/>
		</td>
	</tr>
    <tr>
		<td>
		State:
		</td>
		<td>
		<asp:TextBox ID="Partner_state" runat="server"/>
		</td>
	</tr>
    <tr>
		<td>
		Zip Code:
		</td>
		<td>
		<asp:TextBox ID="Partner_zipcode" runat="server"/>
		</td>
	</tr>
	<tr>
		<td class="auto-style1">
		    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
		</td>
		<td class="auto-style1">
		<asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btn_cancel" />
		</td>
	</tr>
</table>




</asp:Panel>
    

</asp:Content>
