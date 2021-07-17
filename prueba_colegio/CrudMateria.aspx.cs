using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaDeClases;

namespace prueba_colegio
{
    public partial class CrudMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsMateria  materia = new ClsMateria();
                materia.listaMateria(ref gdvTablaMateria);
                ClsListas lista = new ClsListas();
                lista.listaProfesores(ref ddlProfesor);
            }
        }

        protected void gdvTablaMateria_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow fila = (GridViewRow)((Control)e.CommandSource).NamingContainer;
            int index = fila.RowIndex;
            if (e.CommandName == "Actualizar")
            {
                ClsMateria materia = new ClsMateria();
                txtCodiMateria.Text = gdvTablaMateria.Rows[index].Cells[0].Text;
                txtNombreMate.Text = gdvTablaMateria.Rows[index].Cells[1].Text;
                ddlProfesor.Text = gdvTablaMateria.Rows[index].Cells[2].Text;
                materia.listaMateria(ref gdvTablaMateria);
            }
            if (e.CommandName == "Eliminar")
            {
                ClsMateria materia = new ClsMateria();
                materia.EliminarMateria(int.Parse(gdvTablaMateria.Rows[index].Cells[0].Text));
                materia.listaMateria(ref gdvTablaMateria);
            }
        }


        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            materia materiaDto = new materia();
            ClsMateria materia = new ClsMateria();

            materiaDto.CodiMateria = int.Parse(txtCodiMateria.Text);
            materiaDto.NombreMate = txtNombreMate.Text;
            materiaDto.profesores_IdentiProfe = int.Parse(ddlProfesor.SelectedValue.ToString()); ; 
            materia.ActualizarMateria(materiaDto);
            materia.listaMateria(ref gdvTablaMateria);
        }

    }
}