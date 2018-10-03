<%@ Page Title="" Language="C#" MasterPageFile="~/UserView.Master" AutoEventWireup="true" CodeBehind="petMart.aspx.cs" Inherits="PetShop.petMart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        .style1
        {
            width: 100%;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="content">
    <table class="style1">
        <tr>
            <td colspan="2" 
                style="text-align: center; font-size: x-large; font-family: 'Bookman Old Style'; font-weight: 700; color: #0000FF">
               View All Animals Here</td>
        </tr>
        
        <tr>
            <td class="style4">
                Category</td>
            <td class="style6">
               <asp:DropDownList ID="DropDownList1" runat="server" Width="135px" 
                    AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>Dog</asp:ListItem>
                    <asp:ListItem>Cat</asp:ListItem>
                    <asp:ListItem>Birds</asp:ListItem>
                    <asp:ListItem>Fish</asp:ListItem>
                    <asp:ListItem>Rat</asp:ListItem>
                    <asp:ListItem>Rabbit</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        
          <tr>
            <td class="style4" colspan="2">
                <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" 
                    RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <asp:Image ID="ImageButton1" runat="server" Height="180px" 
                            Width="185px"  ImageUrl='<%# "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("Image")) %>'  />
                        <br />
                        <br />
                        Category:
                        <asp:Label ID="CategoryLabel"  runat="server" Text='<%# Eval("Category") %>' />
                        <br />
                        Breed:
                        <asp:Label ID="BreedLabel" runat="server"  Text='<%# Eval("Breed") %>' />
                        <br />
                        Age:
                        <asp:Label ID="AgeLabel" runat="server" Text='<%# Eval("Age") %>' />
                        <br />
                        Description:
                        <asp:Label ID="DescriptionLabel" runat="server" 
                            Text='<%# Eval("Description") %>' />

                             Owner:
                        <asp:Label ID="OwnerLabel" runat="server" 
                            Text='<%# Eval("User_Name") %>' />


                        <br />                        
                        <asp:ImageButton ID="ImageButton2" runat="server" Height="49px" 
                            ImageUrl="~/images/buyNowBig.jpg" onclick="ImageButton2_Click" Width="95px" PostBackUrl='<%# String.Format("Buy.aspx?Breed={0}&Owner={1}",Eval("Breed"),Eval("User_Name")) %>' />
                        <br />
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
       
         <tr>
            <td colspan="2" 
                style="text-align: center; font-size: x-large; font-family: 'Bookman Old Style'; font-weight: 700; color: #0000FF">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:PetDbConnectionString6 %>" 
                    
                    
                    SelectCommand="SELECT * FROM [tbl_Animal] WHERE (([Category] = @Category) )">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="Category" 
                            PropertyName="SelectedValue" Type="String" DefaultValue="Dog" />
                        
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        
       
    </table>

</div>

</asp:Content>
