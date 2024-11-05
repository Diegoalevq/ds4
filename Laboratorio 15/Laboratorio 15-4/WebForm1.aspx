<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_15_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Suma de dos Números: "></asp:Label>
        <p>
            <asp:TextBox ID="txtNum1" runat="server" OnTextChanged="txtNum1_TextChanged"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="+"></asp:Label>
            <asp:TextBox ID="txtNum2" runat="server" OnTextChanged="txtNum2_TextChanged"></asp:TextBox>
            <asp:Button ID="btnIgual" runat="server" Height="25px" OnClick="btnIgual_Click" style="margin-top: 0px" Text="=" />
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
