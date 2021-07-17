<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroCalificacion.aspx.cs" Inherits="prueba_colegio.RegistroCalificacion" %>

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
                <asp:Label ID="LblCodiCalificacion" runat="server" Text="Codigo de Calificación: "></asp:Label>
                <asp:TextBox ID="TxtCodiCalificacion" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblCalificacion" runat="server" Text="Nombre Materia: "></asp:Label>
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
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
        </div>
    </form>
</body>
</html>
