using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibreriaDeClases;

namespace prueba_colegio
{
    public partial class RegistroMaterias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClsListas lista = new ClsListas();
                lista.listaProfesores(ref ddlProfesor);
            }
        }


        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            materia materiaDto = new materia();
            ClsMateria materiaDao = new ClsMateria();
            materiaDto.CodiMateria = int.Parse(TxtCodiMateria.Text);
            materiaDto.NombreMate = txtNombreMate.Text;
            materiaDto.profesores_IdentiProfe = int.Parse(ddlProfesor.SelectedValue.ToString()); ;
            materiaDao.RegistrarMateria(materiaDto);
        }

    }
}