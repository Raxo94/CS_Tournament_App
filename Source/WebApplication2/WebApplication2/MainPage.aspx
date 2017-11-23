<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        CS TURNAMENT APP<br />
        <asp:Button ID="ButtonRegisterT" runat="server" Text="Register Player" OnClick="ButtonRegisterPlayer_Click" />
    
        <asp:Button ID="ButtonRegisterTurnament" runat="server" OnClick="ButtonRegisterTurnament_Click" Text="Register Turnament" style="height: 29px" />
    
    <div>
    
        <asp:Button ID="ButtonRefresh" runat="server" OnClick="ButtonRefresh_Click" Text="Refresh" Width="171px" />
        <br />
        <br />
        <asp:Label ID="LabelTurnaments" runat="server" Text="Turnaments"></asp:Label>
    
    </div>
        <asp:ListBox ID="ListBoxTurnaments" runat="server" Height="447px" Width="261px" OnSelectedIndexChanged="ListBoxPlayers_SelectedIndexChanged"></asp:ListBox>
    </form>
</body>
</html>
