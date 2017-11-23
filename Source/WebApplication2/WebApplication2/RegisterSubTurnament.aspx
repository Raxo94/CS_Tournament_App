<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterSubTurnament.aspx.cs" Inherits="WebApplication2.RegisterSubTurnament" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Register SubTurnament<br />
        Name Of Parent Turnament:&nbsp;
        <asp:TextBox ID="TextBoxParent" runat="server" Width="179px"></asp:TextBox>
        <br />
        Name Of New Sub Turnament:&nbsp;
        <asp:TextBox ID="TextBoxSub" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        Available Turnaments</div>
        <asp:ListBox ID="ListBoxTurnaments" runat="server" Height="204px" Width="255px"></asp:ListBox>
        <asp:Button ID="ButtonRefresh" runat="server" OnClick="ButtonRefresh_Click" Text="Refresh" />
        <br />
        <p>
            <asp:Button ID="ButtonRegister" runat="server" OnClick="ButtonRegister_Click" Text="Register" />
            <asp:Button ID="ButtonCancel" runat="server" OnClick="ButtonCancel_Click" Text="Go Back" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelResult" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
