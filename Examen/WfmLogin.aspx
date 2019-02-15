<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfmLogin.aspx.cs" Inherits="Examen.WfmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div aling="center">
            <table width="40%">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>

                    </td>
                    
                </tr>
                <tr>
                    <td colspan="2">
                        &nbsp;</td>
                    
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="User:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox type="password" ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click"  />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
