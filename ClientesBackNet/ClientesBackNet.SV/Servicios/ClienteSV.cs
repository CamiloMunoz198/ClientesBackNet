using ClienteBackNet.LN.Logica;
using ClientesBackNet.EN.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ClientesBackNet.SV.Servicios
{
    public class ClienteSV(IConfiguration configuration, IHostEnvironment environment) : ControllerBase
    {
        private readonly IConfiguration configuration = configuration;
        private readonly IHostEnvironment environment = environment;
        private ClienteLN? ClienteLN;

        public virtual async Task<IActionResult> ConsultarClienteSV(String Identificacion)
        {
            try
            {
                ClienteEN clienteEN = new ClienteEN
                {
                    Identificacion = Convert.ToInt64(Identificacion)
                };
                ClienteLN = new ClienteLN(configuration, environment);
                await ClienteLN.ConsultarClienteLN(clienteEN);
                return StatusCode(ClienteLN.respuestas.Estado, ClienteLN.respuestas);
            }
            catch (Exception ex)
            {
                //Agregar un log de error aquí si es necesario con mensajes más detallados por correo
                return StatusCode(500, new Dictionary<string, object>() { { "Mensaje", $"Error al consultar el metodo ConsultarClienteSV:{ex.Message}" } });
            }
        }
    }
}
