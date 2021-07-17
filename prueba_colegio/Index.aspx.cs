using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaDeClases;

namespace prueba_colegio
{
    public partial class Index : System.Web.UI.Page
    {
        protected void btnProfesor_Click(object sender, EventArgs e)
        {
            profesores profesorDto = new profesores();
            ClsProfesores profesorDao = new ClsProfesores();


            profesorDto = profesorDao.login(txtIdentiProfe.Text, txtClave.Text);
            if (profesorDto != null)
            {

                Session["IdentiProfe"] = profesorDto.IdentiProfe;
                Session["Nombre"] = profesorDto.Nombre;
                Session["Apellido"] = profesorDto.Apellido;
                Session["Edad"] = profesorDto.Edad;
                Session["Direccion"] = profesorDto.Direccion;
                Session["Telefono"] = profesorDto.Telefono;

                Response.Redirect("RegistroProfesor.aspx", false);
            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrecta";
            }
        }

        protected void btnAlumno_Click(object sender, EventArgs e)
        {
            alumno alumnoDto = new alumno();
            ClsAlumno alumnoDao = new ClsAlumno();


            alumnoDto = alumnoDao.login(txtIdentiProfe.Text, txtClave.Text);
            if (alumnoDto != null)
            {

                Session["CodiAlumno"] = alumnoDto.CodiAlumno;
                Session["Nombre"] = alumnoDto.Nombre;
                Session["Apellido"] = alumnoDto.Apellido;

                Response.Redirect("RegistroAlumno.aspx", false);
            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrecta";
            }
        }


    }
}


        