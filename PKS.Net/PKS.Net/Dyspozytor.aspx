<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dyspozytor.aspx.cs" Inherits="PKS.Net.Dyspozytor" %>

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
            <table  style="width: 50%; height: 70%; margin:auto">
                <tr>
                    <td style="border-right:dotted">
                        <asp:Button ID="ButMiejsc" runat="server" Text="Miejscowości" OnClick="ButMiejsc_Click" Width="100%" />
                    </td>
                    <td style="height:50px">
                        <asp:Button ID="ButHarm" runat="server" Text="Harmonogram Ruchu pojazdu po trasie" Width="119%" Height="100%" OnClick="ButHarm_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"; style="border-right:dotted">
                        <asp:Button ID="ButOdcinek" runat="server" Text="Odcinek" Width="100%" OnClick="ButOdcinek_Click" />
                    </td>
                    <td>
                        <asp:Button ID="ButKierTrasa" runat="server" Text="Kierowca w Trasie" Width="100%" OnClick="ButKierTrasa_Click" />
                    </td>
                </tr>
                <tr>
                    <td style="border-right:dotted">
                        <asp:Button ID="ButOdcinekTrasa" runat="server" Text="Odcinki w Trasach" Width="100%" OnClick="ButOdcinekTrasa_Click" />
                    </td>
                    <td>
                        <asp:Button ID="ButIloPas" runat="server" Text="Ilość Pasażerów" Width="100%" OnClick="ButIloPas_Click" />
                    </td>
                </tr>
                <tr>
                    <td style="border-right:dotted">
                        <asp:Button ID="ButTras" runat="server" Text="Trasy" Width="100%" OnClick="ButTras_Click" />
                    </td>
                </tr>
                <tr>
                    <td style="border-right:dotted">
                        <asp:Button ID="ButKurs" runat="server" Text="Kursy" Width="100%" OnClick="ButKurs_Click" />
                    </td>
                </tr>
                
            </table>
        </div>
        </div>
    </form>
</body>
</html>
