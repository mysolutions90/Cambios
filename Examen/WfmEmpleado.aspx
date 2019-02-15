<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WfmEmpleado.aspx.cs" Inherits="Examen.WfmEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
            <td>Nombre</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox> </td>
        </tr>
         <tr>
            <td>Apellido</td>
            <td>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox> </td>
        </tr>
         <tr>
            <td>Cedula</td>
            <td>
                <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox> </td>
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
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="103px" OnClick="btnGuardar_Click"  />
             </td>
        </tr>
    </table>
</asp:Content>
