<%@ Page Title="" Language="C#" MasterPageFile="~/UserView.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PetShop.Login" %>
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
                Login Form</td>
        </tr>
        <tr>
            <td class="style3">
                Select</td>
            <td class="style3">
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="L" 
                    Text="Registered User" />
&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Admin" GroupName="L" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                Enter User Name</td>
            <td class="style3">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Enter Password</td>
            <td class="style4">
                <asp:TextBox ID="TextBox2" TextMode="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
       
           
        <tr>
            <td class="style2" colspan="2">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Clear" />
            &nbsp;Not Registered
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Register.aspx">CLick Here</asp:LinkButton>
            </td>
        </tr>
    </table>

</div>
</asp:Content>
