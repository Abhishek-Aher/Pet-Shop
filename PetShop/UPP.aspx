<%@ Page Title="" Language="C#" MasterPageFile="~/AdminView.Master" AutoEventWireup="true" CodeBehind="UPP.aspx.cs" Inherits="PetShop.UPP" %>
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
            }
        .style4
        {
            font-family: "Bookman Old Style";
            font-size: medium;
            text-align: left;
        }
     .style5
     {
         font-family: "Bookman Old Style";
         font-size: medium;
         width: 287px;
     }
     .style6
     {
         font-family: "Bookman Old Style";
         font-size: medium;
         text-align: left;
         width: 287px;
     }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
    <table class="style1">
        <tr>
            <td colspan="3" 
                
                style="text-align: center; font-size: x-large; font-family: 'Bookman Old Style'; font-weight: 700; color: #0000FF">
                Update Existing Pet</td>
        </tr>
        <tr>
            <td class="style3">
                Select Category</td>
            <td class="style5">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="135px" 
                    AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>Dog</asp:ListItem>
                    <asp:ListItem>Cat</asp:ListItem>
                    <asp:ListItem>Birds</asp:ListItem>
                    <asp:ListItem>Fish</asp:ListItem>
                    <asp:ListItem>Rat</asp:ListItem>
                    <asp:ListItem>Rabbit</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style3" rowspan="4" style="vertical-align: top">
                <asp:Image ID="Image2" runat="server" Height="137px" Width="200px" />
            </td>
        </tr>
        <tr>
            <td class="style4">
                Select Breed</td>
            <td class="style6">
                <asp:DropDownList ID="DropDownList2" runat="server" Width="135px" 
                    AutoPostBack="True" onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                    <asp:ListItem>--Select--</asp:ListItem>
                    </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style4">
               Age</td>
            <td class="style6">
                <asp:DropDownList ID="DropDownList3" runat="server" Width="135px" 
                    AutoPostBack="True" onselectedindexchanged="DropDownList3_SelectedIndexChanged">
                    <asp:ListItem>--Select--</asp:ListItem>
                    </asp:DropDownList></td>
        </tr>
        <tr>
            <td class="style4">
                Description</td>
            <td class="style6">
                <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="3">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Update" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Remove" />
            </td>
        </tr>
    </table>

</div>
</asp:Content>
