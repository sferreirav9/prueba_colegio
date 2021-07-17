using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaDeClases;

namespace prueba_colegio
{
    public partial class RegistrarAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
            protected void btnRegistrar_Click(object sender, EventArgs e)
            {
                alumno alumnoDto = new alumno();
                ClsAlumno alumnoDao = new ClsAlumno();
                alumnoDto.CodiAlumno = int.Parse(txtCodiAlumno.Text);
                alumnoDto.Nombre = txtNombre.Text;
                alumnoDto.Apellido = txtApellido.Text;
                alumnoDto.Correo = txtCorreo.Text;
                alumnoDto.Clave = txtClave.Text;
                alumnoDao.RegistrarAlumno(alumnoDto);
            }
    }
}