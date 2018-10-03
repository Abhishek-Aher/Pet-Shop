<%@ Page Title="" Language="C#" MasterPageFile="~/AdminView.Master" AutoEventWireup="true" CodeBehind="ViewR.aspx.cs" Inherits="PetShop.ViewR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            font-family: "Bookman Old Style";
            font-size: medium;
            text-align: center;
        }
        .style3
        {
            font-family: "Bookman Old Style";
            font-size: medium;
            height: 26px;
        }
        .style4
        {
            font-family: "Bookman Old Style";
            font-size: medium;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
    <table class="style1">
        <tr>
            <td colspan="2" 
                style="text-align: center; font-size: x-large; font-family: 'Bookman Old Style'; font-weight: 700; color: #0000FF">
               View All Request</td>
        </tr>
        
        <tr>
            <td colspan="2" >
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource1" Height="125px" Width="526px">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                        <asp:BoundField DataField="Contact" HeaderText="Contact" 
                            SortExpression="Contact" />
                        <asp:BoundField DataField="Address" HeaderText="Address" 
                            SortExpression="Address" />
                        <asp:BoundField DataField="Animal" HeaderText="Animal" 
                            SortExpression="Animal" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
         <tr>
            <td colspan="2" 
                style="text-align: center; font-size: x-large; font-family: 'Bookman Old Style'; font-weight: 700; color: #0000FF">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:PetDbConnectionString6 %>" 
                    SelectCommand="SELECT * FROM [tbl_Adopt]"></asp:SqlDataSource>
            </td>
        </tr>
        
       
    </table>

</div>

</asp:Content>
