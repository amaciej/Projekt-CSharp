<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DodajPas.aspx.cs" Inherits="PKS.Net.DodajPas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#90EE90">
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="hfPasId" runat="server" />
            <asp:Label ID="Label1" runat="server" Text="Aby zapisać się do kursu uzupełnij dane"></asp:Label>
            <br />
            <br />
            <table> 
                
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Imię"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextImie" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Nazwisko"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TextNazw" runat="server"></asp:TextBox>
                    </td>
                </tr>
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
                        <asp:Button ID="ButAdd" runat="server" Text="Zapisz się" OnClick="ButAdd_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
                    <td colspan="2">
                        <asp:Label ID="LblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                        <asp:Label ID="LblSukces" runat="server" Text="" ForeColor="Green"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
