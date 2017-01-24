<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>

      </div>
        <asp:Button ID="button1" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Calibri" Font-Size="48pt" Height="80px" Width="81px" OnClick="button1_Click" Enabled="False" />
        <asp:Button ID="button2" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Calibri" Font-Size="48pt" Height="80px" Width="81px" OnClick="button2_Click" Enabled="False" />
        <asp:Button ID="button3" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Calibri" Font-Size="48pt" Height="80px" Width="81px" OnClick="button3_Click" Enabled="False"/>
        <br />
        <asp:Button ID="button4" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Calibri" Font-Size="48pt" Height="80px" Width="81px" OnClick="button4_Click" Enabled="False"/>
        <asp:Button ID="button5" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Calibri" Font-Size="48pt" Height="80px" Width="81px" OnClick="button5_Click" Enabled="False"/>
        <asp:Button ID="button6" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Calibri" Font-Size="48pt" Height="80px" Width="81px" OnClick="button6_Click" Enabled="False"/>
        <br />
        <asp:Button ID="button7" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Calibri" Font-Size="48pt" Height="80px" Width="81px" OnClick="button7_Click" EnableTheming="True" Enabled="False"/>
        <asp:Button ID="button8" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Calibri" Font-Size="48pt" Height="80px" Width="81px" OnClick="button8_Click" Enabled="False"/>
        <asp:Button ID="button9" runat="server" BackColor="White" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Calibri" Font-Size="48pt" Height="80px" Width="81px" OnClick="button9_Click"/>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="restartButton" runat="server" BackColor="White" Font-Bold="True" Font-Names="Calibri" Font-Size="10pt" Height="35px" Text="Play Game" Width="80px" OnClick="restartButton_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="turnLabel" runat="server" Text="Turn: Player One" Visible="False"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;<br />
&nbsp;&nbsp;
        <asp:Label ID="MessageLabel" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="hsLabel" runat="server" Visible="False"></asp:Label>
        <br />
        <p id="high">
            <asp:Label ID="Label1" runat="server" Text="Congratulations! You reached the highscore list!" Visible="False"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Enter your name: " Visible="False"></asp:Label>
&nbsp;
            <asp:TextBox ID="nameTextBox" runat="server" Visible="False"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" Visible="False" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Please enter name!!" Visible="False"></asp:Label>
        </p>
      </form>
</body>
</html>
