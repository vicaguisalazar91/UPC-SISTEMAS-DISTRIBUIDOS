<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmSkier.aspx.cs" Inherits="App.frmSkier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table style="width: 100%">
        <tr>
            <td colspan="3"><h1>Esquiadores</h1></td>
        </tr>
        <tr>
            <td rowspan="4" style="width: 281px">&nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Id Esquiador:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSkierId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Nombre:</td>
            <td>
                <asp:TextBox ID="txtSkierName" runat="server" Width="378px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Fecha de nacimiento:</td>
            <td>
                <asp:Calendar ID="calBirthDay" runat="server"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td>Federación afiliado:</td>
            <td>
                <asp:DropDownList ID="ddlFedeList" runat="server" Height="16px" Width="395px">
                </asp:DropDownList>
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
