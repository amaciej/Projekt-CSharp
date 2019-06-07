<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HarmRuchuPojazd.aspx.cs" Inherits="PKS.Net.HarmRuchuPojazd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#90EE90">
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfKursId" runat="server" />
            <table>
               
                <tr>
                    <td>
                        
                    </td>
                    <td colspan="2">
                        
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
            <asp:GridView ID="gvKursy" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Nazwa" HeaderText="Nazwa Trasy" />
                    <asp:BoundField DataField="Id_Autokaru" HeaderText="Id_Autokaru" />
                    <asp:BoundField DataField="Dni" HeaderText="Dni" />
                    <asp:BoundField DataField="Godz_Początek" HeaderText="Godz Początek" />
                    <asp:BoundField DataField="Godz_Koniec" HeaderText="Godz Koniec" />
                    <asp:BoundField DataField="Ilość_Pasażerów" HeaderText="Ilość Pasażerów" />
                </Columns>
            </asp:GridView>
            <br />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Id Kursu"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextId" runat="server"></asp:TextBox>
                    </td>
                    <td colspan="2">
                        <asp:Button ID="ButPokaz" runat="server" Text="Wyświetl" OnClick="ButPokaz_Click" />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="gvHarm" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Miejscowość_S" HeaderText="Miejscowość_S" />
                    <asp:BoundField DataField="Miejscowości_K" HeaderText="Miejscowości_K" />
                    <asp:BoundField DataField="Godz_Początek" HeaderText="Godz Początek" />
                    <asp:BoundField DataField="Godz_Koniec" HeaderText="Godz Koniec" />
                    <asp:BoundField DataField="Id_Autokaru" HeaderText="Id Autokaru" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
