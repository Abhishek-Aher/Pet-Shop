<%@ Page Title="" Language="C#" MasterPageFile="~/AAdminView.Master" AutoEventWireup="true" CodeBehind="AddPA.aspx.cs" Inherits="PetShop.AddPA" %>
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
                Add New Accessory</td>
        </tr>
        <tr>
            <td class="style3">
                Select Category</td>
            <td class="style3">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="135px">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>Dog</asp:ListItem>
                    <asp:ListItem>Cat</asp:ListItem>
                    <asp:ListItem>Birds</asp:ListItem>
                    <asp:ListItem>Fish</asp:ListItem>
                    <asp:ListItem>Rat</asp:ListItem>
                    <asp:ListItem>Rabbit</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Enter Accessory Name</td>
            <td class="style4">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Cost</td>
            <td class="style4">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Description</td>
            <td class="style4">
                <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Upload Image</td>
            <td class="style4">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Clear" />
            </td>
        </tr>
    </table>

</div>
</asp:Content>
