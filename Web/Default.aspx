<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 
        <table>     
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="DNI"></asp:Label></td>
                <td><asp:TextBox ID="tbDni" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
                    
                </td>
                <td><asp:TextBox ID="tbApellido" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
                </td>
                <td><asp:TextBox ID="tbNombre" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="btnBuscar"      runat="server" OnClick="btnBuscar_Click"    Text="Buscar" />
                    <asp:Button ID="btnInsertar"    runat="server" OnClick="btnInsertar_Click"  Text="Insertar" />                    
                    <asp:Button ID="btnModificar"   runat="server" OnClick="btnModificar_Click" Text="Modificar" />
                    <asp:Button ID="btnBorrar"      runat="server" OnClick="btnBorrar_Click"    Text="Borrar" />
                    <asp:Button ID="btnLimpiarFiltros"      runat="server" OnClick="btnLimpiarFiltros_Click"    Text="Limpiar Filtros" />
                </td>

            </tr>
        </table>

        <asp:Label ID="lblError" runat="server" ForeColor="Red" Text=""></asp:Label>

        

        <br />

        <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />

        </asp:GridView>
   
        
        <br />
   
        
    </form>
</body>
</html>
