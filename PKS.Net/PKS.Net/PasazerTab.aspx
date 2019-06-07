<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasazerTab.aspx.cs" Inherits="PKS.Net.PasazerTab" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#90EE90">
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfPasId" runat="server" />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Imię"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextImie" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Nazwisko"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextNazw" runat="server"></asp:TextBox>
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
            <asp:GridView ID="gvPas" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Imię" HeaderText="Imię" />
                    <asp:BoundField DataField="Nazwisko" HeaderText="Nazwisko" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID ="lnkView" runat="server" CommandArgument='<%#Eval("Id_Pasażer")%>' OnClick="lnk_OnClick">Pokaż</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
