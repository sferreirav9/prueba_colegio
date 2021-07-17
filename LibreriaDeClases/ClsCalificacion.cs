using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;


namespace LibreriaDeClases
{
    public class ClsCalificacion
    {


        public string RegistrarCalificacion(calificacion califi)
        {
            //Declaración de variables
            string mensaje;
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();

            //Se creo el Try Catch para que nos muestre el mensaje de si se registra o se presenta un errror.
            try
            {
                baseDeDatos.calificacion.InsertOnSubmit(califi);
                baseDeDatos.SubmitChanges();
                mensaje = "Se registro la Calificación";
            }
            //Si no se registra mostrará el siguiente mensaje
            catch (Exception ex)
            {
                mensaje = "Error al registrar la Calificación" + ex.Message;
                throw;
            }
            //Como es un metodo string debe tener un retorno en este caso es el mensaje. 
            return mensaje;
        }

        public string ActualizarCalificacion(calificacion califi)
        {
            //Declaración de variables
            string mensaje;
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var calificacionActualizar = (from cali in baseDeDatos.calificacion where cali.CodiCalificacion == cali.CodiCalificacion select cali).FirstOrDefault();
                if (calificacionActualizar != null)
                {
                    calificacionActualizar.Calificacion1 = califi.Calificacion1;
                    calificacionActualizar.Aprobo = califi.Aprobo;
                    calificacionActualizar.FechaCalificacion = califi.FechaCalificacion;
                    calificacionActualizar.materia = califi.materia;
                    calificacionActualizar.alumno_CodiAlumno = califi.alumno_CodiAlumno;
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se actualizo la calificación";
                }
                else
                {
                    mensaje = "Usuario No existe";
                }
            }
            //Si no se registra mostrará el siguiente mensaje
            catch (Exception ex)
            {
                mensaje = "Error al actualizar la calificación" + ex.Message;
                throw;
            }
            //Como es un metodo string debe tener un retorno en este caso es el mensaje. 
            return mensaje;
        }
        public string EliminarCalificacion(int codicalificacion)
        {
            //Declaración de variables
            string mensaje;
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();


            try
            {
                var calificacionEliminar = (from calificacion in baseDeDatos.calificacion where calificacion.CodiCalificacion == codicalificacion select calificacion).FirstOrDefault();
                if (calificacionEliminar != null)
                {
                    baseDeDatos.calificacion.DeleteOnSubmit(calificacionEliminar);
                    baseDeDatos.SubmitChanges();
                    mensaje = "Se eliminó la Calificación";
                }
                else
                {
                    mensaje = "Usuario No existe";
                }
            }
            //Si no se registra mostrará el siguiente mensaje
            catch (Exception ex)
            {
                mensaje = "Error al eliminar la Calificación" + ex.Message;
                throw;
            }
            //Como es un metodo string debe tener un retorno en este caso es el mensaje. 
            return mensaje;
        }

        public void listaCalificacion(ref GridView gdvTablaCalificacion)
        {
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();
            gdvTablaCalificacion.DataSource = (from cali in baseDeDatos.calificacion select cali).ToList();
            gdvTablaCalificacion.DataBind();
        }

        public calificacion listaCalificacionId(int codiCalificacion)
        {
            //Llamado de la base de datos
            OrmDataContext baseDeDatos = new OrmDataContext();
            var calificacion = (from cal in baseDeDatos.calificacion where cal.CodiCalificacion == codiCalificacion select cal).FirstOrDefault();
            return calificacion;
        }


    }
}
