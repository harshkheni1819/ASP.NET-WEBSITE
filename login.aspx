    <%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-3.6.0.min.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jquery.validate/1.19.3/jquery.validate.min.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jquery.validate.unobtrusive/3.2.11/jquery.validate.unobtrusive.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 159px;
            color:papayawhip;   
            
            font-size:x-large;
        }
        .auto-style2 {
            width: 472px;
        }
        .auto-style3 {
            width: 472px;
            height: 29px;
        }
        .auto-style4 {
            width: 159px;
            height: 29px;
            color:papayawhip;
            font-size:x-large;
        }
        .auto-style5 {
            height: 29px;
        }
        body {
            background-color:grey;
        }
        #Button1 {
            background-color:black;
            color:whitesmoke;
        }
        td {
            color:papayawhip;
            font-size:x-large;
        }
        .auto-style6 {
            width: 472px;
            height: 25px;
        }
        .auto-style7 {
            width: 159px;
            height: 25px;
            color: papayawhip;
            font-size: x-large;
        }
        .auto-style8 {
            height: 25px;
        }
        .background {
            background-image: url('image/BACK.jpg');
            background-size: cover;
            height:500px;
            
        }
    </style>
</head>
<body style="height: 464px">
    <form id="form1" runat="server">
    <div style="height: 95px; font-size:xx-large; color:floralwhite">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LOGIN PAGE<br />
        <br />
        <br />
        <asp:Label ID="errorMSG" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
       <div class="background">
        <table style="width:100%;">
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7">Username :</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox1" runat="server" Height="22px"></asp:TextBox>
                    <%--<asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="TextBox1" ErrorMessage="Username is required." ForeColor="Red"></asp:RequiredFieldValidator>--%>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">Password :</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server" Height="22px"></asp:TextBox>
                    <%--<asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="TextBox2" ErrorMessage="Password is required." ForeColor="Red"></asp:RequiredFieldValidator>--%>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Signup" />
                    <br />
                </td>
            </tr>
        </table>
     </div>
    </form>
</body>
</html>

