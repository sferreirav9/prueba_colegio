<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrudAlumno.aspx.cs" Inherits="prueba_colegio.CrudAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="pnlConsulta" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Lista Alumnos"></asp:Label>
                <asp:GridView ID="gdvTablaAlumno" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="gdvTablaAlumno_RowCommand" Width="599px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="CodiAlumno" HeaderText="Código Alumno" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                        <asp:BoundField DataField="Correo" HeaderText="Correo" />
                        <asp:BoundField DataField="Clave" HeaderText="Clave" />
                        <asp:TemplateField HeaderText="Acciones">
                            <ItemTemplate>
                                <asp:ImageButton Width="20px" ID="imgActualizar" runat="server" ImageUrl="~/resource/img/editar.png" CommandName="Actualizar" />
                                <asp:ImageButton ID="imgEliminar" runat="server" ImageUrl="~/resource/img/eliminar.png" CommandName="Eliminar" Width="20px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </asp:Panel>
            <asp:Panel ID="pnlActualizar" runat="server">
                <asp:Label ID="Label2" runat="server" Text="Actualizar Datos"></asp:Label>
                <div>
                    <div>
                        <asp:Label ID="lblCodiAlumno" runat="server" Text="Código Alumno:"></asp:Label>
                        <asp:TextBox ID="txtCodiAlumno" runat="server" Enabled="false"></asp:TextBox>
                    </div>
                    <div>
                <asp:Label ID="lblNombre" runat="server" Text="Nombre: "></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblApellido" runat="server" Text="Apellido: "></asp:Label>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblCorreo" runat="server" Text="Edad: "></asp:Label>
                <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblClave" runat="server" Text="Clave: "></asp:Label>
                <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
            </div>
                    <div>
                        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
                    </div>
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
