using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace LibreriaDeClases
{
   public  class ClsMateria
    {

        public string RegistrarMateria(materia mate)
        {
            //Declaración de variables
            string mensaje;
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();

            //Se creo el Try Catch para que nos muestre el mensaje de si se registra o se presenta un errror.
            try
            {
                baseDeDatos.materia.InsertOnSubmit(mate);
                baseDeDatos.SubmitChanges();
                mensaje = "Se registro la materia";
            }
            //Si no se registra mostrará el siguiente mensaje
            catch (Exception ex)
            {
                mensaje = "Error al registrar la materia" + ex.Message;
                throw;
            }
            //Como es un metodo string debe tener un retorno en este caso es el mensaje. 
            return mensaje;
        }

        public string ActualizarMateria(materia mate)
        {
            //Declaración de variables
            string mensaje;
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var materiaActualizar = (from mr in baseDeDatos.materia where mr.CodiMateria == mate.CodiMateria select mr).FirstOrDefault();
                if (materiaActualizar != null)
                {
                    materiaActualizar.NombreMate = mate.NombreMate;
                    materiaActualizar.profesores_IdentiProfe = mate.profesores_IdentiProfe;
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se actualizo la materia";
                }
                else
                {
                    mensaje = "Usuario No existe";
                }
            }
            //Si no se registra mostrará el siguiente mensaje
            catch (Exception ex)
            {
                mensaje = "Error al actualizar la materia" + ex.Message;
                throw;
            }
            //Como es un metodo string debe tener un retorno en este caso es el mensaje. 
            return mensaje;
        }
        public string EliminarMateria(int codiMate)
        {
            //Declaración de variables
            string mensaje;
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var materiaEliminar = (from mr in baseDeDatos.materia where mr.CodiMateria == codiMate select mr).FirstOrDefault();
                if (materiaEliminar != null)
                {
                    baseDeDatos.materia.DeleteOnSubmit(materiaEliminar);
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se eliminó la materia";
                }
                else
                {
                    mensaje = "Usuario No existe";
                }
            }
            //Si no se registra mostrará el siguiente mensaje
            catch (Exception ex)
            {
                mensaje = "Error al eliminar la materia" + ex.Message;
                throw;
            }
            //Como es un metodo string debe tener un retorno en este caso es el mensaje. 
            return mensaje;
        }

        public void listaMateria(ref GridView gdvTablaMateria)
        {
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();
            gdvTablaMateria.DataSource = (from mat in baseDeDatos.materia select mat).ToList();
            gdvTablaMateria.DataBind();
        }

        public materia listaMateriaId(int codiMate)
        {
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();
            var materia = (from mate in baseDeDatos.materia where mate.CodiMateria == codiMate select mate).FirstOrDefault();
            return materia;
        }
    }
}
