<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WfmDepartamento.aspx.cs" Inherits="Examen.WfmDepartamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <table>
        <tr>
            <td colspan="2">Departamento</td>
        </tr>
        <tr>
            <td class="text-center">Codigo</td>
            <td>
                <asp:Label ID="lblCodigo" runat="server"></asp:Label> </td>
        </tr>
         <tr>
            <td>Descripcion</td>
            <td>
                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox> </td>
        </tr>
         <tr>
            <td>Direccion</td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox> </td>
        </tr>
         <tr>
            <td>Mensaje</td>
            <td>
                <asp:Label ID="LblMensaje" runat="server"></asp:Label>
                </td>
        </tr>
         <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="103px" OnClick="btnGuardar_Click" />
             </td>
        </tr>
    </table>
</asp:Content>
