<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmFederation.aspx.cs" Inherits="App.frmFederation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width: 100%">
        <tr>
            <td colspan="3"><h1>Federaciones</h1></td>
        </tr>
        <tr>
            <td style="width: 366px; " rowspan="2"></td>
            <td style="width: 202px; height: 30px">
                <asp:Label ID="Label1" runat="server" Text="Id Federación:"></asp:Label>
            </td>
            <td style="height: 30px">
                <asp:TextBox ID="txtFedeId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 202px">
                <asp:Label ID="Label2" runat="server" Text="Nombre Federación:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFedeNom" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="3" class="center">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />&nbsp;&nbsp;
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />&nbsp;&nbsp;
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" />&nbsp;&nbsp;
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
            </td>
        </tr>
    </table>





</asp:Content>
