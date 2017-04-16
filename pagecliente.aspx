<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="pagecliente.aspx.cs" Inherits="pagecliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    

    <table style="width: 100%" align="center">
        <tr>
            <td colspan="3">
                <h1> Clientes
                </h1>
            </td>
        </tr>
        <tr>
            <td rowspan="4" style="width: 323px">
                <img alt="cliente" src="images/clientes.jpg" 
                    style="width: 348px; height: 160px; text-align: center" /></td>
            <td style="width: 119px">
                <asp:Label ID="Label1" runat="server" Text="Id Cliente"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtcliente" runat="server"></asp:TextBox>
                <asp:Button ID="btnbuscar" runat="server" onclick="btnbuscar_Click" 
                    Text="Buscar" />
                <asp:DropDownList ID="drpclientes" runat="server" AutoPostBack="True" 
                    DataSourceID="SqlDataSourceClientes" DataTextField="nombre" 
                    DataValueField="idcliente" 
                    onselectedindexchanged="drpclientes_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceClientes" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:clientesConnectionString %>" 
                    SelectCommand="SELECT [nombre], [idcliente] FROM [cliente]">
                </asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td style="width: 119px">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 119px">
                <asp:Label ID="Label3" runat="server" Text="Dirección"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 119px">
                <asp:Label ID="Label4" runat="server" Text="Teléfono"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 323px">
                <asp:Label ID="lblestado" runat="server"></asp:Label>
            </td>
            <td style="width: 119px">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnagregar" runat="server" Text="Agregar" 
                    onclick="btnagregar_Click" />
                <asp:Button ID="btneliminar" runat="server" onclick="btneliminar_Click" 
                    Text="Eliminar" />
            </td>
        </tr>
    </table>

    

</asp:Content>

