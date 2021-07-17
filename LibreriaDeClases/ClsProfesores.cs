using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace LibreriaDeClases
{
    public class ClsProfesores
    {
        public string RegistrarProfesor(profesores profe)
        {
            //Declaración de variables
            string mensaje;
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();
           
            //Se creo el Try Catch para que nos muestre el mensaje de si se registra o se presenta un errror.
            try
            {
                baseDeDatos.profesores.InsertOnSubmit(profe);
                baseDeDatos.SubmitChanges();
                mensaje = "Se registro el profesor";
            }
            //Si no se registra mostrará el siguiente mensaje
            catch (Exception ex)
            {
                mensaje = "Error al registrar el profesor" + ex.Message;
                throw;
            }
            //Como es un metodo string debe tener un retorno en este caso es el mensaje. 
            return mensaje;
        }

        public string ActualizarProfesor(profesores profe)
        {
            //Declaración de variables
            string mensaje;
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var profesorActualizar = (from pr in baseDeDatos.profesores where pr.IdentiProfe == profe.IdentiProfe select pr).FirstOrDefault();
                if (profesorActualizar != null)
                {
                    profesorActualizar.Nombre = profe.Nombre;
                    profesorActualizar.Apellido = profe.Apellido;
                    profesorActualizar.Direccion = profe.Direccion;
                    profesorActualizar.Telefono = profe.Telefono;
                    profesorActualizar.Correo = profe.Correo;
                    profesorActualizar.Clave = profe.Clave;
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se actualizo el profesor";
                }
                else
                {
                    mensaje = "Usuario No existe";
                }              
            }
            //Si no se registra mostrará el siguiente mensaje
            catch (Exception ex)
            {
                mensaje = "Error al actualizar el profesor" + ex.Message;
                throw;
            }
            //Como es un metodo string debe tener un retorno en este caso es el mensaje. 
            return mensaje;
        }
        public string EliminarProfesor(int IdentiProfe)
        {
            //Declaración de variables
            string mensaje;
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var profesorEliminar = (from pr in baseDeDatos.profesores where pr.IdentiProfe == IdentiProfe select pr).FirstOrDefault();
                if (profesorEliminar != null)
                {
                    baseDeDatos.profesores.DeleteOnSubmit(profesorEliminar);
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se eliminó el profesor";
                }
                else
                {
                    mensaje = "Usuario No existe";
                }
            }
            //Si no se registra mostrará el siguiente mensaje
            catch (Exception ex)
            {
                mensaje = "Error al eliminar el profesor" + ex.Message;
                throw;
            }
            //Como es un metodo string debe tener un retorno en este caso es el mensaje. 
            return mensaje;
        }

        public void listaProfesores(ref GridView gdvTablaProfesor)
        {
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();
            gdvTablaProfesor.DataSource = (from pro in baseDeDatos.profesores select pro).ToList();
            gdvTablaProfesor.DataBind();
        }

        public profesores listaProfesoresId(int IdentiProfe)
        {
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();
            var profesores = (from pro in baseDeDatos.profesores where pro.IdentiProfe ==IdentiProfe select pro).FirstOrDefault();

            return profesores;

        }
        public profesores login(string correo, string clave)
        {
            OrmDataContext baseDeDatos = new OrmDataContext();
            var login = (from pro in baseDeDatos.profesores where pro.Correo == correo && pro.Clave == clave select pro).FirstOrDefault();
            return login;
        }

    }
}
