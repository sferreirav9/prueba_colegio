using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace LibreriaDeClases
{
    public class ClsListas
    {
        OrmDataContext baseDeDatos = new OrmDataContext();
        public void listaAlumno(ref DropDownList ddlListaAlumno)
        {

            ddlListaAlumno.DataSource = (from al in baseDeDatos.alumno select al).ToList();
            ddlListaAlumno.DataValueField = "CodiAlumno";
            ddlListaAlumno.DataTextField = "Nombre";
            ddlListaAlumno.DataBind();

        }


        public void listaMateria(ref DropDownList ddlListaMateria)
        {

            ddlListaMateria.DataSource = (from ma in baseDeDatos.materia select ma).ToList();
            ddlListaMateria.DataValueField = "CodiMateria";
            ddlListaMateria.DataTextField = "NombreMate";
            ddlListaMateria.DataBind();
        }

        public void listaProfesores(ref DropDownList ddlListaProfesores)
        {

            ddlListaProfesores.DataSource = (from pr in baseDeDatos.profesores select pr).ToList();
            ddlListaProfesores.DataValueField = "IdentiProfe";
            ddlListaProfesores.DataTextField = "Nombre";
            ddlListaProfesores.DataBind();
        }



    }
}
