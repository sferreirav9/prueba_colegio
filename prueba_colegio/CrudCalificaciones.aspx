<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrudCalificaciones.aspx.cs" Inherits="prueba_colegio.CrudCalificaciones" %>

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
                <asp:Label ID="Label1" runat="server" Text="Lista de Calificaciones"></asp:Label>
                <asp:GridView ID="gdvTablaCalificaciones" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="gdvTablaCalificaciones_RowCommand" Width="599px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="CodiCalificacion" HeaderText="Código Calificacion" />
                        <asp:BoundField DataField="Calificacion" HeaderText="Calificacion" />
                        <asp:BoundField DataField="Aprobo" HeaderText="Aprobo" />
                        <asp:BoundField DataField="FechaCalificacion" HeaderText="Fecha Calificacion" />
                        <asp:BoundField DataField="Materia_CodiMateria" HeaderText="Materia" />
                        <asp:BoundField DataField="alumno_CodiAlumno" HeaderText="Alumno" />
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
                        <asp:Label ID="lblCodiCalificacion" runat="server" Text="Código Calificación:"></asp:Label>
                        <asp:TextBox ID="txtCodiCalificacion" runat="server" Enabled="false"></asp:TextBox>
                    </div>
                    <div>
                <asp:Label ID="lblCalificacion" runat="server" Text="Calificación: "></asp:Label>
                <asp:TextBox ID="txtCalificacion" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblAprobo" runat="server" Text="Aprobo: "></asp:Label>
                <asp:TextBox ID="txtAprobo" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblFechaCali" runat="server" Text="Fecha Calificación: "></asp:Label>
                <asp:TextBox ID="txtFechaCali" type="date" runat="server"></asp:TextBox>
            </div>
             <div>
                   <asp:Label ID="lblMateria" runat="server" Text="Materia: "></asp:Label>
                 <asp:DropDownList ID="ddlMateria" runat="server"></asp:DropDownList>
            </div>
            <div>
                  <asp:Label ID="lblAlumno" runat="server" Text="Alumno: "></asp:Label>
                <asp:DropDownList ID="ddlAlumno" runat="server"></asp:DropDownList>
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
