<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kierowca.aspx.cs" Inherits="PKS.Net.Kierowca" %>

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
                        <asp:Button ID="ButInfo" runat="server" Text="Informacje" Width="100%" OnClick="ButInfo_Click" />
                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:Button ID="ButIloPas" runat="server" Text="Ilość Pasażerów" Width="100%" OnClick="ButIloPas_Click"  />
                    </td>
                </tr>
            </table>
        </div>
        </div>
    </form>
</body>
</html>
