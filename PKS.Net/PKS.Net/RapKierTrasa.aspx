<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RapKierTrasa.aspx.cs" Inherits="PKS.Net.RapKierTrasa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#90EE90">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Wybierz czas aby pokazać kierowców, którzy są aktualnie w trasie
"></asp:Label>
            <table>              
                <tr>
                    <td>
                        <asp:TextBox ID="TextCzas" runat="server"></asp:TextBox>
                    </td>
                    <td colspan="2">
                        <asp:Button ID="ButPokaz" runat="server" Text="Wyświetl" OnClick="ButPokaz_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
                    <td colspan="2">
                        <asp:Label ID="LblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="dgvRap" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Id_Kierowcy" HeaderText="Id Kierowcy" />
                    <asp:BoundField DataField="Imię" HeaderText="Imię" />
                    <asp:BoundField DataField="Nazwisko" HeaderText="Nazwisko" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
