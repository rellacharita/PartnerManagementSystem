<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend.Master" AutoEventWireup="true" CodeBehind="RoleManagement.aspx.cs" Inherits="ISSI.PartnerManagementSystem.Web.RoleManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        .form1 {
            max-width: 100px;
            padding: 5px 15px 25px;
            margin: 0 auto;
            background-color: #eee;
            border-radius: 15px;
            border: 1px solid rgba(0, 0, 0, 0.1);
        }

        .auto-style1 {
            font-size: xx-large;
        }

        .auto-style2 {
            color: #990000;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="roleName" ForeColor="#333333" GridLines="None" Width="384px" OnRowCommand="GridView1_RowCommand">
        <AlternatingRowStyle BackColor="White" />
        <Columns>

          <asp:BoundField DataField="roleID" HeaderText="RoleID" SortExpression="roleID" ReadOnly="true" />
            <asp:BoundField DataField="roleName" HeaderText="Role Name" SortExpression="roleName" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnEdit" runat="server" Width="60" Text="Edit" CommandName="EditButton" CommandArgument="<%# ((GridViewRow) Container).RowIndex+1 %>" />
                    <asp:Button ID="btnMenu" runat="server" Width="60" Text="Menu" CommandName="MenuButton" CommandArgument="<%# ((GridViewRow) Container).RowIndex+1 %>" />
                    <asp:Button ID="btnRights" runat="server" Width="60" Text="Rights" CommandName="RightsButton" CommandArgument="<%# ((GridViewRow) Container).RowIndex+1 %>" />

                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField ShowHeader="False"></asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>



    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString2 %>" DeleteCommand="DELETE FROM [Roles] WHERE [Role_name] = @Role_name" InsertCommand="INSERT INTO [Roles] ([RoleID], [Role_name]) VALUES (@RoleID, @Role_name)" ProviderName="<%$ ConnectionStrings:CustomerConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [Roles]" UpdateCommand="UPDATE [Roles] SET [Role_name] = @Role_name WHERE [RoleID] = @RoleID" OnSelecting="SqlDataSource2_Selecting">
        <DeleteParameters>
            <asp:Parameter Name="Role_name" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="RoleID" Type="String" />
            <asp:Parameter Name="Role_name" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Role_name" Type="String" />
            <asp:Parameter Name="RoleID" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>

    <br />
    <asp:Label ID="Label1" runat="server" Text="Add New Role:"></asp:Label>
    &nbsp;<asp:TextBox ID="Role_name" runat="server"></asp:TextBox>
    &nbsp;<asp:Button ID="ConfirmNew" runat="server" OnClick="Confirm_new" Text="Confirm" />

    <asp:FileUpload ID="FileUpload1" runat="server" />

</asp:Content>
