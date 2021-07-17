<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="prueba_colegio.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"  crossorigin="anonymous">
    <link href="resource/css/main.css" rel="stylesheet" />
    <title></title>
</head>
<body class="landing" id="two">
    <!-- modal-->

    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content bg-dark">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Login</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <form id="form1" runat="server" class="">
                        <div class="form-group ">
                            <asp:Label ID="lblIdentiProfe" runat="server" Text="Correo electrónico:"></asp:Label>
                            <asp:TextBox ID="txtIdentiProfe" runat="server"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="lblClave" runat="server" Text="Clave:"></asp:Label>
                            <asp:TextBox ID="txtClave" runat="server" ></asp:TextBox>
                        </div>
                        <div class="mt-4 d-flex justify-content-center">
                            <asp:Button CssClass="mr-2" ID="btnProfesor" runat="server" Text="Profesor" OnClick="btnProfesor_Click" />
                            <asp:Button ID="btnAlumno" runat="server" Text="Alumno" OnClick="btnAlumno_Click" />
                        </div>
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <!-- Page Wrapper 
        
        -->
    <div id="page-wrapper">
        
        <!-- Header -->
        <header id="header" class="alt">
            <h1><a href="#two" class="more scrolly">Colegio</a></h1>
        </header>

        <!-- Banner -->
        <section id="banner" >
            <img src="resource/img/colegio.jpg" class="img-fluid img-thumbnail">
            <div class="inner">
                <h2>Bienvenido al Sistema para Colegio</h2>
                <p>
                    Another fine responsive<br />
                    site template freebie<br />
                    crafted by
                </p>
                <ul class="actions">
                    
                    <li><a href="#" class="button special" data-toggle="modal" data-target="#exampleModal">Ingresar</a></li>
                </ul>
            </div>
            <a href="#one" class="more scrolly">Registrate</a>
        </section>

        <!-- One -->
        <section id="one" class="wrapper style1 special">
            <div class="inner">
                <header class="major">
                    
                    <h2>Arcu aliquet vel lobortis ata nisl<br />
                        eget augue amet aliquet nisl cep donec</h2>
                    <p>
                        Aliquam ut ex ut augue consectetur interdum. Donec amet imperdiet eleifend<br />
                        fringilla tincidunt. Nullam dui leo Aenean mi ligula, rhoncus ullamcorper.
                    </p>
                </header>
                <ul class="icons major">
                    <li><a href="RegistroProfesor.aspx" class="button fit">Registrate Profesor</a></li>
                    <li><a href="RegistroAlumno.aspx" class="button fit">Registrate Alumno</a></li>
                </ul>
            </div>
        </section>
        <!-- CTA -->
        <!-- Footer -->
        <footer id="footer">
            <ul class="icons">
                <li><a href="#" class="icon fa-twitter"><span class="label">Twitter</span></a></li>
                <li><a href="#" class="icon fa-facebook"><span class="label">Facebook</span></a></li>
                <li><a href="#" class="icon fa-instagram"><span class="label">Instagram</span></a></li>
                <li><a href="#" class="icon fa-dribbble"><span class="label">Dribbble</span></a></li>
                <li><a href="#" class="icon fa-envelope-o"><span class="label">Email</span></a></li>
            </ul>
        </footer>

    </div>
    <!-- Scripts -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <script src="resource/js/jquery.min.js"></script>
    <script src="resource/js/jquery.scrollex.min.js"></script>
    <script src="resource/js/jquery.scrolly.min.js"></script>
    <script src="resource/js/skel.min.js"></script>
    <script src="resource/js/util.js"></script>
    <script src="resource/js/main.js"></script>
</body>
</html>
