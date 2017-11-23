<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Hello, This is my CS App. BYE</p>
        <p>
            <asp:TextBox ID="TextBoxName" runat="server">Oskar</asp:TextBox>
            <asp:Button ID="ButtonName" runat="server" OnClick="ButtonName_Click" Text="OK" Height="21px" style="margin-bottom: 0px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="LabelIPAdress" runat="server" Text=""></asp:Label>
        </p>
    </form>
</body>
</html>
