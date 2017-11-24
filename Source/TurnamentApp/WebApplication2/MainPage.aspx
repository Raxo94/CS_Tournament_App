<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        TURNAMENT APP<br />
        <asp:Button ID="ButtonHandlePlayers" runat="server" Text="Handle Players" OnClick="ButtonHandlePlayers_Click" Width="208px" />
    
    <div>
    
        <asp:Button ID="ButtonHandleTurnament" runat="server" OnClick="ButtonHandleTurnament_Click" style="margin-bottom: 1px" Text="Handle Turnaments" Width="211px" />
        <br />
        <br />
        <asp:Label ID="LabelTurnaments" runat="server" Text="Turnaments"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelPlayer" runat="server" Text="Players"></asp:Label>
    
    </div>
        <asp:ListBox ID="ListBoxTurnaments" runat="server" Height="447px" Width="261px"></asp:ListBox>
        <asp:ListBox ID="ListBoxPlayers" runat="server" Height="447px" Width="281px"></asp:ListBox>
        <p>
    
        <asp:Button ID="ButtonRefresh" runat="server" OnClick="ButtonRefresh_Click" Text="Refresh" Width="171px" />
        <asp:Button ID="ClearTurnaments" runat="server" OnClick="ClearTurnaments_Click" Text="Clear Turnaments" />
            <asp:Button ID="ButtonClearPlayers" runat="server" OnClick="ButtonClearPlayers_Click" Text="Clear Players" />
        </p>
    </form>
</body>
</html>
