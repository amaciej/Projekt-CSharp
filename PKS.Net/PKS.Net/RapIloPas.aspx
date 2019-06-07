<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RapIloPas.aspx.cs" Inherits="PKS.Net.RapIloPas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#90EE90">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Wproawdź Id_Kursu oraz zakres dla którego chcesz uzyskać raport o liczbie pasażerów"></asp:Label>
            <br />
            <br />
            <table> 
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Id Kurs"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextId" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        
                    </td>
                    <td colspan="2">
                        <asp:Label ID="Label3" runat="server" Text="Data i Godz. Od"></asp:Label>                        
                    </td>
                    <td>
                        <asp:TextBox ID="TextDataOd" runat="server"></asp:TextBox>                        
                    </td>
                    <td colspan="2">
                                               
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Data i Godz. Do"></asp:Label>                                                
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextDataDo" runat="server"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td>
                        
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
                    <asp:BoundField DataField="Ilość Pasażerów" HeaderText="Ilość Pasażerów" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
