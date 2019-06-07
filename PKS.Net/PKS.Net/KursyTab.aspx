<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KursyTab.aspx.cs" Inherits="PKS.Net.KursyTab" %>

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
                        <asp:Label ID="Label3" runat="server" Text="Nazwa Trasy"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:DropDownList ID="ddlNazwa" runat="server" AppendDataBoundItems="true">
                            <asp:ListItem Text="<Wybierz Trase>" Value="0" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Id Autokaru"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextAuto" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Dni"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextDni" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Godz Początek"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextGodzP" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Godz Koniec"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextGodzK" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Ilość Pasażerów"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextIlosc" runat="server"></asp:TextBox>
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
            <asp:GridView ID="gvKursy" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Nazwa" HeaderText="Nazwa Trasy" />
                    <asp:BoundField DataField="Id_Autokaru" HeaderText="Id_Autokaru" />
                    <asp:BoundField DataField="Dni" HeaderText="Dni" />
                    <asp:BoundField DataField="Godz_Początek" HeaderText="Godz Początek" />
                    <asp:BoundField DataField="Godz_Koniec" HeaderText="Godz Koniec" />
                    <asp:BoundField DataField="Ilość_Pasażerów" HeaderText="Ilość Pasażerów" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID ="lnkView" runat="server" CommandArgument='<%#Eval("Id_Kursy")%>' OnClick="lnk_OnClick">Pokaż</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
