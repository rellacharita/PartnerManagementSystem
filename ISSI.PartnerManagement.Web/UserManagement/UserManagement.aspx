<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend.Master" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="ISSI.PartnerManagementSystem.Web.UserManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>

        .form1{
            max-width: 100px;
          padding: 5px 15px 25px;
          margin: 0 auto;
          background-color: #eee;
          border-radius:15px;
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
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="UserId" ForeColor="#333333" GridLines="None" Width="940px" OnRowCommand="GridView1_RowCommand"   >
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="UserId" HeaderText="ID" SortExpression="UserId" ReadOnly="True" />
        <asp:BoundField DataField="UserName" HeaderText="User" SortExpression="UserName" />
        <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
        <asp:BoundField DataField="EmailAddress" HeaderText="Email" SortExpression="EmailAddress"/>
        <asp:BoundField DataField="Mobile" HeaderText="Mobile" SortExpression="Mobile"  />
        <asp:BoundField DataField="DateOfBirth" HeaderText="Date of Birth" SortExpression="DateOfBirth" />
       
       <asp:TemplateField>  
                        <ItemTemplate>  
                            <asp:Button ID="btnEdit" runat="server" Width="60" Text="Edit" CommandName="EditButton" CommandArgument="<%# ((GridViewRow) Container).RowIndex+1 %>" />  
                        </ItemTemplate>  
                    </asp:TemplateField>               
                <asp:TemplateField ShowHeader="False">
                   
                </asp:TemplateField> 

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


    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString2 %>" SelectCommand="SELECT * FROM [c_details]" DeleteCommand="DELETE FROM [c_details] WHERE [ID] = @ID" InsertCommand="INSERT INTO [c_details] ([cuser], [cpass], [email], [mobile], [dob], [ID]) VALUES (@cuser, @cpass, @email, @mobile, @dob, @ID)" UpdateCommand="UPDATE [c_details] SET [cuser] = @cuser, [cpass] = @cpass, [email] = @email, [mobile] = @mobile, [dob] = @dob WHERE [ID] = @ID">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="cuser" Type="String" />
            <asp:Parameter Name="cpass" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="mobile" Type="String" />
            <asp:Parameter Name="dob" Type="String" />
            <asp:Parameter Name="ID" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="cuser" Type="String" />
            <asp:Parameter Name="cpass" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="mobile" Type="String" />
            <asp:Parameter Name="dob" Type="String" />
            <asp:Parameter Name="ID" Type="String" />
        </UpdateParameters>
        
    </asp:SqlDataSource>


    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString2 %>" SelectCommand="SELECT * FROM [c_details]"></asp:SqlDataSource>




<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString2 %>" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [Role_name], [RoleID] FROM [Roles]">
</asp:SqlDataSource>


    <br />
    <br />
    <asp:Label ID="Label1" runat="server" style="font-weight: 700; text-decoration: underline; color: #990000" Text="Add New User"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Cuser" runat="server" style="color: #990000" Text="User Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="user" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Cpass" runat="server" style="color: #990000" Text="Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" style="color: #990000" Text="Email:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="email" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" style="color: #990000" Text="Mobile:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label6" runat="server" style="color: #990000" Text="Date Of Birth:"></asp:Label>
    &nbsp;<asp:TextBox ID="dob" runat="server" TextMode="Date" Width="156px"></asp:TextBox>
    &nbsp;&nbsp;<br />
    &nbsp;<asp:Label ID="Label7" runat="server" ForeColor="#990000" Text="Role:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource4" DataTextField="Role_name" DataValueField="RoleID">
    </asp:DropDownList>

    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString2 %>" SelectCommand="SELECT [RoleID], [Role_name] FROM [Roles]"></asp:SqlDataSource>

    <br />
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" ForeColor="#990000" OnClick="addUser_Click" Text="Add" Width="88px" />
&nbsp; 


</asp:Content>
