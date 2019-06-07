<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RapKier.aspx.cs" Inherits="PKS.Net.RapKier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#90EE90">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Wprawdź swój numer identyfikacyjny aby wyświetlić potrzebne Ci informacje"></asp:Label>
            <br />
            <br />
            <table> 
                
                <tr>
                    <td>
                        <asp:TextBox ID="TextId" runat="server"></asp:TextBox>
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
                    <asp:BoundField DataField="Twój PESEL" HeaderText="Twój PESEL" />
                    <asp:BoundField DataField="Id_Kursy" HeaderText="Id_Kursy" />
                    <asp:BoundField DataField="Nazwa Trasy" HeaderText="Nazwa Trasy" />
                    <asp:BoundField DataField="Dni" HeaderText="Dni" />
                    <asp:BoundField DataField="Godz_Początek" HeaderText="Godz Początek" />
                    <asp:BoundField DataField="Godz_Koniec" HeaderText="Godz Koniec" />
                    <asp:BoundField DataField="Id_Autokaru" HeaderText="Id Autokaru" />
                    <asp:BoundField DataField="Marka" HeaderText="Marka" />
                    <asp:BoundField DataField="Model" HeaderText="Model" />
                    <asp:BoundField DataField="Nr_Rejstracyjny" HeaderText="Nr_Rejstracyjny" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
