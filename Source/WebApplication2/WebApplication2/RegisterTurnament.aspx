<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterTurnament.aspx.cs" Inherits="WebApplication2.RegisterTurnament" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelRegisterTurnament" runat="server" Text="Register a Turnament"></asp:Label>
        <br />
        <br />
        Name:
        <asp:TextBox ID="TextBoxTurnamentName" runat="server"></asp:TextBox>
    
    </div>
        <p>
            <asp:Button ID="ButtonAddTurnament" runat="server" OnClick="ButtonAddTurnament_Click" Text="Add" />
        </p>
    </form>
</body>
</html>
