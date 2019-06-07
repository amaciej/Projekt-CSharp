<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MojeKursy.aspx.cs" Inherits="PKS.Net.MojeKursy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#90EE90">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Podaj sowje Imię i nazwisko aby wyświtlić swoje kursy"></asp:Label>
            <br />
            <br />
            <table>               
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Imię"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextImie" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Nazwisko"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextNazw" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        
                    </td>
                    <td colspan="2">
                        <asp:Button ID="ButPokaz" runat="server" Text="Wyświetl" OnClick="ButPokaz_Click" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="LblError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="dgvRap" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Nazwa" HeaderText="Nazwa" />
                    <asp:BoundField DataField="Godz_Początek" HeaderText="Godz_Początek" />
                    <asp:BoundField DataField="Godz_Koniec" HeaderText="Godz_Koniec" />
                    <asp:BoundField DataField="Id_Autokaru" HeaderText="Id_Autokaru" />
                    <asp:BoundField DataField="Marka" HeaderText="Marka" />
                    <asp:BoundField DataField="Model" HeaderText="Model" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
