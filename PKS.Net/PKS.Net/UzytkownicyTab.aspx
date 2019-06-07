<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UzytkownicyTab.aspx.cs" Inherits="PKS.Net.UzytkownicyTab" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#90EE90">
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfUzytId" runat="server" />
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Id Uprawnienia"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextUpr" runat="server"></asp:TextBox>
                    </td>
                    <td colspan="2">
                        <asp:Label ID="Label4" runat="server" Text="1: Administrator  |  2: Dyspozytor  |  3: Kierowca  |  4: Pasażer"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Login"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextLogin" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Hasło"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextHaslo" runat="server"></asp:TextBox>
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
            <asp:GridView ID="gvUzyt" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Id_Upr" HeaderText="Id Uprawnienia" />
                    <asp:BoundField DataField="Login" HeaderText="Login" />
                    <asp:BoundField DataField="Hasło" HeaderText="Hasło" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID ="lnkView" runat="server" CommandArgument='<%#Eval("Id_Użyt")%>' OnClick="lnk_OnClick">Pokaż</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
