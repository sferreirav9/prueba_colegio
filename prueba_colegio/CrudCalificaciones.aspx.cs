using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaDeClases;

namespace prueba_colegio
{
    public partial class CrudCalificaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsCalificacion calificacion = new ClsCalificacion();
                calificacion.listaCalificacion(ref gdvTablaCalificaciones);
                ClsListas lista = new ClsListas();
                lista.listaProfesores(ref ddlMateria);
                ClsListas lista2 = new ClsListas();
                lista.listaAlumno(ref ddlAlumno);
            }
        }


        protected void gdvTablaCalificaciones_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow fila = (GridViewRow)((Control)e.CommandSource).NamingContainer;
            int index = fila.RowIndex;
            if (e.CommandName == "Actualizar")
            {
                ClsCalificacion calificacion = new ClsCalificacion();
                txtCodiCalificacion.Text = gdvTablaCalificaciones.Rows[index].Cells[0].Text;
                txtCalificacion.Text = gdvTablaCalificaciones.Rows[index].Cells[1].Text;
                txtAprobo.Text = gdvTablaCalificaciones.Rows[index].Cells[2].Text;
                txtFechaCali.Text = gdvTablaCalificaciones.Rows[index].Cells[3].Text;
                ddlMateria.Text = gdvTablaCalificaciones.Rows[index].Cells[4].Text;
                ddlAlumno.Text = gdvTablaCalificaciones.Rows[index].Cells[5].Text;
                calificacion.listaCalificacion(ref gdvTablaCalificaciones);
            }
            if (e.CommandName == "Eliminar")
            {
                ClsCalificacion calificacion = new ClsCalificacion();
                calificacion.EliminarCalificacion(int.Parse(gdvTablaCalificaciones.Rows[index].Cells[0].Text));
                calificacion.listaCalificacion(ref gdvTablaCalificaciones);
            }
        }


        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            calificacion calificacionesDto = new calificacion();
            ClsCalificacion calificacion = new ClsCalificacion();

            calificacionesDto.CodiCalificacion = int.Parse(txtCodiCalificacion.Text);
            calificacionesDto.Calificacion1 = int.Parse(txtCalificacion.Text);
            calificacionesDto.Aprobo = txtAprobo.Text;
            calificacionesDto.FechaCalificacion = DateTime.Parse(txtFechaCali.Text);
            calificacionesDto.Materia_CodiMateria = int.Parse(ddlMateria.SelectedValue.ToString()); ;
            calificacionesDto.alumno_CodiAlumno = int.Parse(ddlAlumno.SelectedValue.ToString()); ;
            calificacion.ActualizarCalificacion(calificacionesDto);
            calificacion.listaCalificacion(ref gdvTablaCalificaciones);
        }
    }
}