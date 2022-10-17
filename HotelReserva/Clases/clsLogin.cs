using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HotelReserva.Modelos;

namespace HotelReserva.Clases
{
    public class clsLogin
    {
      public Login login { get; set; }
        public string Verificar()
        {
            //Invocar el método insertar
            //Método para grabar en la base de datos
            string SQL = "Inicio_sesion"; //Nombre del procedimiento almacenado
          

            clsConexion oConexion = new clsConexion();
            oConexion.SQL = SQL;
            oConexion.StoredProcedure = true;//Para indicar que es un procedimiento almacenado
            oConexion.AgregarParametro("@prContrasenia", login.contrasenia) ;
            oConexion.AgregarParametro("@prNombre", login.usuario);
           

            if (oConexion.EjecutarSentencia() == 0)
            {
                login.Error = "No esta registrado";
                return login.Error;

            }
            else
            {
                login.Error = oConexion.Error;
                return login.Error;
               
            }
        }
    }
}