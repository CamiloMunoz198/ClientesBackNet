using ClientesBackNet.AD.Repositorios.Contextos;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ClienteBackNet.LN.Utilidades
{
    public class AccesoDatosLN
    {
        //Configuracion de cadena de conexion para entorno desarrollo y produccion
        public ClientesDBContextAD ObtenerCadenaClientes(IConfiguration configuration, IHostEnvironment environtment)
        {
            return environtment.IsDevelopment() ? new ClientesDBContextAD(configuration.GetConnectionString("ConexionSQLClientesDBDev")) : new ClientesDBContextAD(configuration.GetConnectionString("ConexionSQLClientesDBProd"));
        }
    }
}
