<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Polaczenia.aspx.cs" Inherits="PKS.Net.Polaczenia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#90EE90">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Miejscowość_S"></asp:Label>
                    </td>
                    <td colspan="2">
                       
                    </td>
                    <td colspan="2">
                       <asp:Label ID="Label3" runat="server" Text="Miejscowość_K"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                         <asp:DropDownList ID="ddlMiastoS" runat="server" AppendDataBoundItems="true">
                            <asp:ListItem Text="<Wybierz Miasto>" Value="0" />
                        </asp:DropDownList>                        
                    </td>
                    <td colspan="2">
                       
                    </td>
                    <td colspan="2">
                        <asp:DropDownList ID="ddlMiastoK" runat="server" AppendDataBoundItems="true">
                            <asp:ListItem Text="<Wybierz Miasto>" Value="0" />
                        </asp:DropDownList>
                    </td>
                    <td colspan="2">
                       
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
                    <asp:BoundField DataField="M_Nazwa" HeaderText="M_Nazwa" />
                    <asp:BoundField DataField="Nazwa" HeaderText="Nazwa" />
                    <asp:BoundField DataField="Id_Miejscowości" HeaderText="Id Miejscowości" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
