using ClientesBackNet.SV.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ClientesBackNet.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ClienteSV
    {
        public ClientesController(IConfiguration configuration, IHostEnvironment environment) : base(configuration, environment) {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
        }
        // GET: ClientesController
        [HttpGet("{Identificacion}")]
        public override async Task<IActionResult> ConsultarClienteSV([FromRoute] string Identificacion)
            => await base.ConsultarClienteSV(Identificacion);
    }
}
