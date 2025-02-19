<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<style>
    h1 
    {
        color:black;
    }
    #button1 {
        background-color:black;
        color:whitesmoke;
    }
    body {
        background-color:grey;
    }
</style>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>WELCOME TO HOME PAGE</h1>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGOUT" />
        </p>
    </div>
    </form>
</body>
</html>
