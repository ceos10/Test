<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="pageregistro.aspx.cs" Inherits="pageregistro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>
    Registro de Empleados
    </h1>
    <table style="width: 100%; border: 1px solid #cccccc">
        <tr>
            <td rowspan="6" style="width: 90px">
                <img alt="" src="images/empleados.jpg" style="width: 256px; height: 256px" /></td>
            <td class="right" style="width: 125px">
                <asp:Label ID="Label1" runat="server" Text="Cédula"></asp:Label>
            </td>
            <td style="width: 159px">
                <asp:TextBox ID="txtcedula" runat="server"></asp:TextBox>
            </td>
            <td>
                <h1> Resumen de Cálculo
                </h1></td>
        </tr>
        <tr>
            <td class="right" style="width: 125px">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td style="width: 159px">
                <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
            </td>
            <td>
                
                <asp:Label ID="Label9" runat="server" Text="Empleado"></asp:Label>
                <br />
                <asp:Label ID="lblempleado" runat="server" Text=""></asp:Label>
                
            </td>
        </tr>
        <tr>
            <td class="right" style="width: 125px">
                <asp:Label ID="Label3" runat="server" Text="Tipo Empleado"></asp:Label>
            </td>
            <td style="width: 159px">
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    DataSourceID="SqlDataSourceTipo" DataTextField="descripcion" 
                    DataValueField="id_tipo" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceTipo" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:registroConnectionString %>" 
                    SelectCommand="SELECT * FROM [tipo_empleado]"></asp:SqlDataSource>
            </td>
            <td>
               
                <asp:Label ID="Label10" runat="server" Text="Cédula"></asp:Label>
                <br />
                <asp:Label ID="lblcedula" runat="server" Text=""></asp:Label>
               
            </td>
        </tr>
        <tr>
            <td class="right" style="width: 125px">
                <asp:Label ID="Label4" runat="server" Text="Salario Por Hora"></asp:Label>
            </td>
            <td style="width: 159px">
                <asp:TextBox ID="txtsalariohora" runat="server"></asp:TextBox>
            </td>
            <td>
                
                <asp:Label ID="Label6" runat="server" Text="Salario Bruto:"></asp:Label>
                <br />
                <asp:TextBox ID="txtsalariobruto" runat="server" ReadOnly="True"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td class="right" style="width: 125px">
                <asp:Label ID="Label5" runat="server" Text="Horas Trabajadas"></asp:Label>
            </td>
            <td style="width: 159px">
                <asp:TextBox ID="txthoras" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Deducciones:"></asp:Label>
                <br />
                <asp:TextBox ID="txtdeduccion" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="right" style="width: 125px">
                &nbsp;</td>
            <td style="width: 159px">
                <asp:Button ID="btncalcular" runat="server" Text="Calcular" 
                    onclick="btncalcular_Click" />
                <asp:Button ID="btnguardar" runat="server" Text="Guardar" 
                    onclick="btnguardar_Click" />
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Salario Neto:"></asp:Label>
                <br />
                <asp:TextBox ID="txtsalarioneto" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="lblestado" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

