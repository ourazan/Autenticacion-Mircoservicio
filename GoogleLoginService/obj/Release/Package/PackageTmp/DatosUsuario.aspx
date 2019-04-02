<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatosUsuario.aspx.cs" Inherits="GoogleLoginService.DatosUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Verdana, Geneva, Tahoma, sans-serif; font-size: x-large; font-weight: bold; font-style: normal; color: #000080">
            Datos Token<br />
            <asp:TextBox ID="TokenTextBox" runat="server" Height="297px" ReadOnly="True" TextMode="MultiLine" Width="681px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="ErrorLabel" runat="server" Font-Bold="False" Font-Size="Medium" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
