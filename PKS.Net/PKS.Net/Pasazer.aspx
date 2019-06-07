<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pasazer.aspx.cs" Inherits="PKS.Net.Pasazer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="stylesheet" href="AdminStyle.css" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id ="wysrodkowany">
        <div id ="naglowek" style="float: none">
            <img src="bus.png" alt="Logo">
            <table style="margin:auto; position: absolute; left: 20%; top: 22px; border: dashed; width:60%; height: 10% " >
                <tr>
                    <td style="width: 27%; border-right:dashed">
                        <asp:Button ID="ButWyloguj" runat="server" Text="Wylugj się" OnClick="ButWyloguj_Click" Width="100%" Height="35px" />
                    </td>
                    <td style="width: 73%">
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div id ="menu">
            <table  style="width: 30%; height: 30%; margin:auto">
                <tr>
                    <td>
                        <asp:Button ID="ButAdd" runat="server" Text="Dodaj" Width="100%" OnClick="ButInfo_Click" />
                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:Button ID="ButMoje" runat="server" Text="Moje Kursy" Width="100%" OnClick="ButIloPas_Click"  />
                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:Button ID="ButHarm" runat="server" Text="Harmonogram Ruchu Autobusu" Width="100%" OnClick="ButHarm_Click"   />
                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:Button ID="ButPolocz" runat="server" Text="Wyszukaj Połączenia" Width="100%" OnClick="ButPolocz_Click"  />
                    </td>
                </tr>
            </table>
        </div>
        </div>
    </form>
</body>
</html>
