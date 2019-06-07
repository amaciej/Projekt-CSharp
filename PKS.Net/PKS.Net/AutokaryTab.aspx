<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutokaryTab.aspx.cs" Inherits="PKS.Net.AutokaryTab" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#90EE90">
    <form id="form1" runat="server">
        <div style="margin:auto; text-align:center">
            <asp:HiddenField ID="hfAutoId" runat="server" />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Id Kierowcy"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextKier" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Nr Rejstracyjny"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextNr" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Ilość Miejsc"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextIlosc" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Marka"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextMarka" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Model"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextModel" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Rocznik"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextRok" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
                    <td colspan="2">
                        <asp:Button ID="ButSave" runat="server" Text="Zapisz" OnClick="ButSave_Click" />
                        <asp:Button ID="ButUsun" runat="server" Text="Usuń" OnClick="ButUsun_Click" />
                        <asp:Button ID="ButClear" runat="server" Text="Wyczyść" OnClick="ButClear_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
                    <td colspan="2">
                        <asp:Label ID="LblSukces" runat="server" Text="" ForeColor="Green"></asp:Label>
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
            <asp:GridView ID="gvAuto" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Id_Kierowcy" HeaderText="Id Kierowcy" />
                    <asp:BoundField DataField="Nr_Rejstracyjny" HeaderText="Nr Rejstracyjny" />
                    <asp:BoundField DataField="Iilość_Miejsc" HeaderText="Ilość Miejsc" />
                    <asp:BoundField DataField="Marka" HeaderText="Marka" />
                    <asp:BoundField DataField="Model" HeaderText="Model" />
                    <asp:BoundField DataField="Rocznik" HeaderText="Rocznik" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID ="lnkView" runat="server" CommandArgument='<%#Eval("Id_Autokaru")%>' OnClick="lnk_OnClick">Pokaż</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
