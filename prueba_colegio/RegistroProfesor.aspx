<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroProfesor.aspx.cs" Inherits="prueba_colegio.RegistroProfesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblLogueado" runat="server"></asp:Label>

        </div>
        <div>
            <div>
                <asp:Label ID="lblIdentiProfe" runat="server" Text="Identificación: "></asp:Label>
                <asp:TextBox ID="txtIdentiProfe" runat="server"></asp:TextBox>
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
                <asp:Label ID="lblEdad" runat="server" Text="Edad: "></asp:Label>
                <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblDireccion" runat="server" Text="Dirección: "></asp:Label>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblTelefono" runat="server" Text="Telefono: "></asp:Label>
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblCorreo" runat="server" Text="Correo: "></asp:Label>
                <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblClave" runat="server" Text="Clave: "></asp:Label>
                <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
            </div>
        </div>
        <div>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
        </div>
    </form>
</body>
</html>
