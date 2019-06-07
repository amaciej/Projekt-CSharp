<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OdcinekTab.aspx.cs" Inherits="PKS.Net.OdcinekTab" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#90EE90">
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfOdcinekId" runat="server" />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Miejscowość_S"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:DropDownList ID="ddlMiastoS" runat="server" AppendDataBoundItems="true">
                            <asp:ListItem Text="<Wybierz Miasto>" Value="0" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Miejscowość_K"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:DropDownList ID="ddlMiastoK" runat="server" AppendDataBoundItems="true">
                            <asp:ListItem Text="<Wybierz Miasto>" Value="0" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Długość"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextDlugosc" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Godz Odjazdu"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextGodzP" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Godz Przyjazdu"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextGodzK" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Cena Biletu"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextCena" runat="server"></asp:TextBox>
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
            <asp:GridView ID="gvOdcinek" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Miejscowość_S" HeaderText="Miejscowość_S" />
                    <asp:BoundField DataField="Miejscowości_K" HeaderText="Miejscowość_K" />
                    <asp:BoundField DataField="Długość" HeaderText="Długość" />
                    <asp:BoundField DataField="Godz_Początek" HeaderText="Godzina Odjazdu" />
                    <asp:BoundField DataField="Godz_Koniec" HeaderText="Godzina Przyjazdu" />
                    <asp:BoundField DataField="Cena_Biletu" HeaderText="Cena Biletu" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID ="lnkView" runat="server" CommandArgument='<%#Eval("Id_Odcinek")%>' OnClick="lnk_OnClick">Pokaż</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
