<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logowanie.aspx.cs" Inherits="PKS.Net.Logowanie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body style="background-color:#90EE90">
    <form id="form1" runat="server">
        <div>
            <h1 style="margin:auto; text-align:center">Aplikacja internetowa Kursy PKS</h1>
            <br />
            <br />
            <br />
            <br />
            <br />
            <table style="margin:auto;border:5px solid black">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextLogin" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Hasło"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextHaslo" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
                    <td>
                        <asp:Button ID="ButLogin" runat="server" Text="Zaloguj" OnClick="ButLogin_Click" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Label ID="LblError" runat="server" Text="Nieprowaidłowy Login lub Hasło" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
