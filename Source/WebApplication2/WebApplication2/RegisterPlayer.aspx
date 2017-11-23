<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPlayer.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Register a Player-<br />
        Name
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <p>
            Age&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxAge" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonAddPlayer" runat="server" Text="Add" OnClick="ButtonAddPlayer_Click" Width="43px" />
        </p>
    </form>
</body>
</html>
