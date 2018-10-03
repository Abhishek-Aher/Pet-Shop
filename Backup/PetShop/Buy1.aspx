<%@ Page Title="" Language="C#" MasterPageFile="~/UserView.Master" AutoEventWireup="true" CodeBehind="Buy1.aspx.cs" Inherits="PetShop.Buy1" %>
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
                
                style="text-align: left; font-size: x-large; font-family: 'Bookman Old Style'; font-weight: 700; color: #0000FF">
                Bill Number
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr>
            <td class="style3">
                Name</td>
            <td class="style3">
               <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Contact Number</td>
            <td class="style4">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
               Email Id</td>
            <td class="style4">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: left; font-size: x-large; font-family: 'Bookman Old Style'; font-weight: 700; color: #0000FF">
                Product Name</td>
            <td style="text-align: left; font-size: x-large; font-family: 'Bookman Old Style'; font-weight: 700; color: #0000FF">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: left; font-size: x-large; font-family: 'Bookman Old Style'; font-weight: 700; color: #0000FF">
                Cost</td>
            <td style="text-align: left; font-size: x-large; font-family: 'Bookman Old Style'; font-weight: 700; color: #0000FF">
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Clear" />
                &nbsp;</td>
        </tr>
    </table>

</div>
</asp:Content>
