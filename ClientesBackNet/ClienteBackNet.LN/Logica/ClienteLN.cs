using ClienteBackNet.LN.Base;
using ClientesBackNet.AD.Repositorios.Contextos;
using ClientesBackNet.AD.Repositorios.Entidades;
using ClientesBackNet.EN.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ClienteBackNet.LN.Logica
{
    public class ClienteLN : BaseGeneralLN
    {
        private readonly IConfiguration configuration;
        private readonly IHostEnvironment environment;
        public ClienteLN(IConfiguration configuration, IHostEnvironment environment)
        {
            this.configuration = configuration;
            this.environment = environment;
        }

        public Task ConsultarClienteLN(ClienteEN clienteEN)
        {
            // Lógica para crear un pedido
            try
            {
                using (ClientesDBContextAD ClienteDBContextAD = accesoDatos.ObtenerCadenaClientes(configuration, environment))
                {
                    try
                    {
                        var clientes =
                            ClienteDBContextAD.Clientes.Where(c => c.Identificacion == clienteEN.Identificacion)
                            .AsNoTracking()
                            .OrderBy(c => c.Identificacion)

                            .Select(c => new
                            {
                                c.Identificacion,
                                c.NombreCompleto,
                                c.Direccion,
                                c.Celular,
                                c.Email,
                                c.FechaCreacion,
                                c.UsuarioCreacion,
                                c.FechaActualizacion,
                                c.UsuarioActualizacion,
                                c.Activo
                            })
                            .ToList();

                        if (clientes.Any())
                        {
                            respuestas.Respuesta.Add("Clientes", clientes);
                        }
                        else
                        {
                            respuestas.NoEncontrado("No existe información para este cliente");
                        }
                    }
                    catch (Exception ex)
                    {
                        respuestas.Fallido($"Error Al Consultar Cliente En DB.{ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                respuestas.Error500($"Error al consultar Cliente ConsultarClienteLN:{ex.Message}");
            }
            return Task.CompletedTask;
        }
    }
}
