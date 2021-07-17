using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaDeClases;


namespace prueba_colegio
{
    public partial class CrudAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsAlumno alumno = new ClsAlumno();
                alumno.listaAlumno(ref gdvTablaAlumno);
            }

        }
            protected void gdvTablaAlumno_RowCommand(object sender, GridViewCommandEventArgs e)
            {
                GridViewRow fila = (GridViewRow)((Control)e.CommandSource).NamingContainer;
                int index = fila.RowIndex;
                if (e.CommandName == "Actualizar")
                {
                    ClsAlumno alumno = new ClsAlumno();
                    txtCodiAlumno.Text = gdvTablaAlumno.Rows[index].Cells[0].Text;
                    txtNombre.Text = gdvTablaAlumno.Rows[index].Cells[1].Text;
                    txtApellido.Text = gdvTablaAlumno.Rows[index].Cells[2].Text;
                    txtCorreo.Text = gdvTablaAlumno.Rows[index].Cells[3].Text;
                    txtClave.Text = gdvTablaAlumno.Rows[index].Cells[4].Text;
                    alumno.listaAlumno(ref gdvTablaAlumno);
                }
                if (e.CommandName == "Eliminar")
                {
                    ClsAlumno alumno = new ClsAlumno();
                    alumno.EliminarAlumno(int.Parse(gdvTablaAlumno.Rows[index].Cells[0].Text));
                    alumno.listaAlumno(ref gdvTablaAlumno);
                }
            }


            protected void btnActualizar_Click(object sender, EventArgs e)
            {

                alumno alumnoDto = new alumno();
                ClsAlumno alumno = new ClsAlumno();

                alumnoDto.CodiAlumno = int.Parse(txtCodiAlumno.Text);
                alumnoDto.Nombre = txtNombre.Text;
                alumnoDto.Apellido = txtApellido.Text;
                alumnoDto.Correo = txtCorreo.Text;
                alumnoDto.Clave = txtClave.Text;
                alumno.ActualizarAlumno(alumnoDto);
                alumno.listaAlumno(ref gdvTablaAlumno);
            }
    }
}