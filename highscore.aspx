<%@ Page Language="C#" AutoEventWireup="true" CodeFile="highscore.aspx.cs" Inherits="highscore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Congratulations! You reached the highscore list!<br />
        <br />
        <br />
        <br />
        Enter your name:&nbsp;&nbsp;
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="submitButton" runat="server" Text="Submit" />
    
    </div>
    </form>
</body>
</html>
