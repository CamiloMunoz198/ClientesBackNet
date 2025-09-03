using ClienteBackNet.LN.Modelos;
using ClienteBackNet.LN.Utilidades;


namespace ClienteBackNet.LN.Base
{
    public class BaseGeneralLN
    {
        public readonly RespuestasLN respuestas;
        protected readonly AccesoDatosLN accesoDatos;
        public BaseGeneralLN()
        {
            respuestas = new RespuestasLN();
            accesoDatos = new AccesoDatosLN();
        }
    }
}
