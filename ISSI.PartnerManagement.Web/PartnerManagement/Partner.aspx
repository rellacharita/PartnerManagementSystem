<%@ Page Title="" Language="C#" MasterPageFile="~/Frontend.Master" AutoEventWireup="true" CodeBehind="Partner.aspx.cs" Inherits="ISSI.PartnerManagementSystem.Web.Partner" %>
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
   

            <asp:ScriptManager ID="ScriptManager1" runat="server">
               </asp:ScriptManager>

    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand"  DataKeyNames="PartnerID" CellPadding="4" GridLines="None" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="PartnerID" HeaderText="ID" SortExpression="PartnerID" />
                <asp:BoundField DataField="PartnerName" HeaderText="Name" SortExpression="PartnerName" />
                <asp:BoundField DataField="ContactFirstName" HeaderText="First Name" SortExpression="ContactFirstName" />
                <asp:BoundField DataField="ContactMiddleName" HeaderText="Middle Name" SortExpression="ContactMiddleName" />
                <asp:BoundField DataField="ContactLastName" HeaderText="Last Name" SortExpression="ContactLastName" />
                <asp:BoundField DataField="ContactEmail" HeaderText="Email" SortExpression="ContactEmail" />
                <asp:BoundField DataField="ContactPhoneNumber" HeaderText="Phone Number" SortExpression="ContactPhoneNumber" />
                <asp:BoundField DataField="PartnerAddressLine1" HeaderText="Address Line 1" SortExpression="PartnerAddressLine1" />
                <asp:BoundField DataField="PartnerAddressLine2" HeaderText="Address Line 2" SortExpression="PartnerAddressLine2" />
                <asp:BoundField DataField="PartnerCity" HeaderText="City" SortExpression="PartnerCity" />
                <asp:BoundField DataField="PartnerState" HeaderText="State" SortExpression="PartnerState" />
                <asp:BoundField DataField="PartnerZipcode" HeaderText="Zipcode" SortExpression="PartnerZipcode" />
                
                <asp:BoundField />
                
                <asp:TemplateField>  
                        <ItemTemplate>  
                            <asp:Button ID="btnEdit" runat="server" Width="60" Text="Edit" CommandName="EditButton" CommandArgument="<%# ((GridViewRow) Container).RowIndex+1 %>" />  
                        </ItemTemplate>  
                    </asp:TemplateField>               
                <asp:TemplateField ShowHeader="False">
                   
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
      </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString2 %>" ProviderName="<%$ ConnectionStrings:CustomerConnectionString3.ProviderName %>" SelectCommand="SELECT * FROM [Partner]" UpdateCommand="UPDATE [Partner] SET [Contact_fname] = @Contact_fname , [Contact_mname] = @Contact_mname , [Contact_lname] = @Contact_lname WHERE [Partner_id] = @Partner_id " DeleteCommand="DELETE FROM [Partner] WHERE [Partner_id] = @Partner_id  " InsertCommand="INSERT INTO [Partner] VALUES (@Partner_name, @Contact_fname,@Contact_mname,@Contact_lname,@Contact_email,@Contact_phno,@Partner_address_line1,@Partner_address_line2,@Partner_city,@Partner_state,@Partner_zipcode" >
            <UpdateParameters>
                <asp:Parameter Name="Contact_fname" Type="String" />
                <asp:Parameter Name="Contact_mname" Type="String" />
                <asp:Parameter Name="Contact_lname" Type="String" />
                <asp:Parameter Name="Contact_email" Type="String" />
                <asp:Parameter Name="Contact_phno" Type="String" />
                <asp:Parameter Name="Partner_address_line1" Type="String" />
                <asp:Parameter Name="Partner_address_line2" Type="String" />
                <asp:Parameter Name="Partner_city" Type="String" />
                <asp:Parameter Name="Partner_state" Type="String" />
                <asp:Parameter Name="Partner_zipcode" Type="String" />
            </UpdateParameters>
           
            <DeleteParameters>
                <asp:Parameter Name="Contact_fname" Type="String" />
                <asp:Parameter Name="Contact_mname" Type="String" />
                <asp:Parameter Name="Contact_lname" Type="String" />
                <asp:Parameter Name="Contact_email" Type="String" />
                <asp:Parameter Name="Contact_phno" Type="String" />
                <asp:Parameter Name="Partner_address_line1" Type="String" />
                <asp:Parameter Name="Partner_address_line2" Type="String" />
                <asp:Parameter Name="Partner_city" Type="String" />
                <asp:Parameter Name="Partner_state" Type="String" />
                <asp:Parameter Name="Partner_zipcode" Type="String" />
            </DeleteParameters>

            <InsertParameters>
                <asp:Parameter Name="Contact_fname" Type="String" />
                <asp:Parameter Name="Contact_mname" Type="String" />
                <asp:Parameter Name="Contact_lname" Type="String" />
                <asp:Parameter Name="Contact_email" Type="String" />
                <asp:Parameter Name="Contact_phno" Type="String" />
                <asp:Parameter Name="Partner_address_line1" Type="String" />
                <asp:Parameter Name="Partner_address_line2" Type="String" />
                <asp:Parameter Name="Partner_city" Type="String" />
                <asp:Parameter Name="Partner_state" Type="String" />
                <asp:Parameter Name="Partner_zipcode" Type="String" />
            </InsertParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Click here to insert new data" OnClick="Button1_Click" BackColor="White" ForeColor="#990000" /> 
         
    </div>
</asp:Content>
