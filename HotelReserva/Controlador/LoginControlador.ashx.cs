using HotelReserva.Modelos;
using System.IO;
using System.Web;

namespace HotelReserva.Controlador
{
    /// <summary>
    /// Summary description for LoginControlador
    /// </summary>
    public class LoginControlador : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                string DatosLogin;
                StreamReader reader = new StreamReader(context.Request.InputStream);
                DatosLogin = reader.ReadToEnd();


                Login login = JsonConvert.DeserializeObject<Login>(DatosLogin);

                context.Response.Write(ProcesarComando(login));
            }
            catch (Exception ex)
            {
                context.Response.Write(ex.Message);
            }
        }
        private string ProcesarComando(Login login)
        {
            clsLogin oLogin = new clsLogin();
            oLogin.login = login;
            return oLogin.Verificar();
        }

    }
}