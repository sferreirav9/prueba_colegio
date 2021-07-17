using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaDeClases;

namespace prueba_colegio
{
    public partial class RegistroCalificacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsListas lista = new ClsListas();
                lista.listaAlumno(ref ddlAlumno);
                ClsListas lista2 = new ClsListas();
                lista.listaMateria(ref ddlMateria);
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            calificacion calificacionDto = new calificacion();
            ClsCalificacion calificacionDao = new ClsCalificacion();
            calificacionDto.CodiCalificacion = int.Parse(TxtCodiCalificacion.Text);
            calificacionDto.Calificacion1 = int.Parse(txtCalificacion.Text);
            calificacionDto.Aprobo = txtAprobo.Text;
            calificacionDto.FechaCalificacion = DateTime.Parse(txtFechaCali.Text);
            calificacionDto.Materia_CodiMateria = int.Parse(ddlMateria.SelectedValue.ToString()); ;
            calificacionDto.alumno_CodiAlumno = int.Parse(ddlAlumno.SelectedValue.ToString()); ;
            calificacionDao.RegistrarCalificacion(calificacionDto);
        }
    }
}