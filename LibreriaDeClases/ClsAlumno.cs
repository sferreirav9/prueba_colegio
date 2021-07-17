using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace LibreriaDeClases
{
    public class ClsAlumno
    {
        public string RegistrarAlumno(alumno alumn)
        {
            //Declaración de variables
            string mensaje;
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();

            //Se creo el Try Catch para que nos muestre el mensaje de si se registra o se presenta un errror.
            try
            {
                baseDeDatos.alumno.InsertOnSubmit(alumn);
                baseDeDatos.SubmitChanges();
                mensaje = "Se registro el Alumno";
            }
            //Si no se registra mostrará el siguiente mensaje
            catch (Exception ex)
            {
                mensaje = "Error al registrar el Alumno" + ex.Message;
                throw;
            }
            //Como es un metodo string debe tener un retorno en este caso es el mensaje. 
            return mensaje;
        }

        public string ActualizarAlumno(alumno alum)
        {
            //Declaración de variables
            string mensaje;
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var alumnoActualizar = (from al in baseDeDatos.alumno where al.CodiAlumno == alum.CodiAlumno select al).FirstOrDefault();
                if (alumnoActualizar != null)
                {
                    alumnoActualizar.Nombre = alum.Nombre;
                    alumnoActualizar.Apellido = alum.Apellido;
                    alumnoActualizar.Correo = alum.Correo;
                    alumnoActualizar.Clave = alum.Clave;
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se actualizo el Alumno";
                }
                else
                {
                    mensaje = "Alumno No existe";
                }
            }
            //Si no se registra mostrará el siguiente mensaje
            catch (Exception ex)
            {
                mensaje = "Error al actualizar el Alumno" + ex.Message;
                throw;
            }
            //Como es un metodo string debe tener un retorno en este caso es el mensaje. 
            return mensaje;
        }
        public string EliminarAlumno(int CodiAlumn)
        {
            //Declaración de variables
            string mensaje;
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var alumnoEliminar = (from al in baseDeDatos.alumno where al.CodiAlumno == CodiAlumn select al).FirstOrDefault();
                if (alumnoEliminar != null)
                {
                    baseDeDatos.alumno.DeleteOnSubmit(alumnoEliminar);
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se eliminó el Alumno";
                }
                else
                {
                    mensaje = "Alumno No existe";
                }
            }
            //Si no se registra mostrará el siguiente mensaje
            catch (Exception ex)
            {
                mensaje = "Error al eliminar el Alumno" + ex.Message;
                throw;
            }
            //Como es un metodo string debe tener un retorno en este caso es el mensaje. 
            return mensaje;
        }

        public void listaAlumno(ref GridView gdvTablaAlumno)
        {
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();
            gdvTablaAlumno.DataSource = (from alum in baseDeDatos.alumno select alum).ToList();
            gdvTablaAlumno.DataBind();
        }

        public alumno listaAlumnoId(int CodiAlumno)
        {
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();
            var alumno = (from alm in baseDeDatos.alumno where alm.CodiAlumno == CodiAlumno select alm).FirstOrDefault();

            return alumno;

        }
        public alumno login(string correo, string clave)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            var login = (from alum in baseDeDatos.alumno where alum.Correo == correo && alum.Clave == clave select alum).FirstOrDefault();
            return login;
        }
    }
}
