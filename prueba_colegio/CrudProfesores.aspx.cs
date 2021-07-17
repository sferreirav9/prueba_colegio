using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaDeClases;

namespace prueba_colegio
{
    public partial class CrudProfesores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsProfesores profesores = new ClsProfesores();
                profesores.listaProfesores(ref gdvTablaProfesor);
            }
        }
            protected void gdvTablaProfesor_RowCommand(object sender, GridViewCommandEventArgs e)
            {
                GridViewRow fila = (GridViewRow)((Control)e.CommandSource).NamingContainer;
                int index = fila.RowIndex;
                if (e.CommandName == "Actualizar")
                {
                    ClsProfesores profesores = new ClsProfesores();
                    txtIdentiProfe.Text = gdvTablaProfesor.Rows[index].Cells[0].Text;
                    txtNombre.Text = gdvTablaProfesor.Rows[index].Cells[1].Text;
                    txtApellido.Text = gdvTablaProfesor.Rows[index].Cells[2].Text;
                    txtEdad.Text = gdvTablaProfesor.Rows[index].Cells[3].Text;
                    txtDireccion.Text = gdvTablaProfesor.Rows[index].Cells[4].Text;
                    txtTelefono.Text = gdvTablaProfesor.Rows[index].Cells[5].Text;
                    txtCorreo.Text = gdvTablaProfesor.Rows[index].Cells[6].Text;
                    txtClave.Text = gdvTablaProfesor.Rows[index].Cells[7].Text;
                    profesores.listaProfesores(ref gdvTablaProfesor);
                }
                if (e.CommandName == "Eliminar")
                {
                    ClsProfesores profesores = new ClsProfesores();
                    profesores.EliminarProfesor(int.Parse(gdvTablaProfesor.Rows[index].Cells[0].Text));
                    profesores.listaProfesores(ref gdvTablaProfesor);
                }
            }


        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            profesores profesoresDto = new profesores();
            ClsProfesores profesores = new ClsProfesores();

                profesoresDto.IdentiProfe = int.Parse(txtIdentiProfe.Text);
                profesoresDto.Nombre = txtNombre.Text;
                profesoresDto.Apellido = txtApellido.Text;
                profesoresDto.Edad = int.Parse(txtEdad.Text);
                profesoresDto.Direccion = txtDireccion.Text;
                profesoresDto.Telefono = txtTelefono.Text;
                profesoresDto.Correo = txtCorreo.Text;
                profesoresDto.Clave = txtClave.Text;
                profesores.ActualizarProfesor(profesoresDto);
                profesores.listaProfesores(ref gdvTablaProfesor);
            }
        }
}