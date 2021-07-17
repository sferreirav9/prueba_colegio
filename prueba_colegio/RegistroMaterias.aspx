<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroMaterias.aspx.cs" Inherits="prueba_colegio.RegistroMaterias" %>

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
                <asp:Label ID="LblCodiMateria" runat="server" Text="Nombre Materia: "></asp:Label>
                <asp:TextBox ID="TxtCodiMateria" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblNombreMate" runat="server" Text="Nombre Materia: "></asp:Label>
                <asp:TextBox ID="txtNombreMate" runat="server"></asp:TextBox>
            </div>
            <asp:DropDownList ID="ddlProfesor" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
        </div>
    </form>
</body>
</html>
