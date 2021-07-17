
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaDeClases;

namespace prueba_colegio
{ 
    
    public partial class RegistroProfesor : System.Web.UI.Page
    {
        protected void btnRegistrar_Click(object sender, EventArgs e)
            {
            profesores profesoresDto = new profesores();
            ClsProfesores profesoresDao = new ClsProfesores();
            profesoresDto.IdentiProfe = int.Parse(txtIdentiProfe.Text);
            profesoresDto.Nombre = txtNombre.Text;
            profesoresDto.Apellido = txtApellido.Text;
            profesoresDto.Edad = int.Parse(txtEdad.Text);
            profesoresDto.Direccion = txtDireccion.Text;
            profesoresDto.Telefono = txtTelefono.Text;
            profesoresDto.Correo = txtCorreo.Text;
            profesoresDto.Clave = txtClave.Text;
            profesoresDao.RegistrarProfesor(profesoresDto);
        }

     
    }
}