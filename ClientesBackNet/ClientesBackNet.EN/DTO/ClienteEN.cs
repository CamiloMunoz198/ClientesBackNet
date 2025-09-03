

namespace ClientesBackNet.EN.DTO
{
    public class ClienteEN
    {
       public Int64 Identificacion { get; set; }
       public string? NombreCompleto { get; set; }
       public string? Direccion { get; set; }
       public string? Celular { get; set; }
       public string? Email { get; set; }
       public DateTime FechaCreacion { get; set; }
       public string? UsuarioCreacion { get; set; }
       public DateTime FechaActualizacion { get; set; }
       public string? UsuarioActualizacion { get; set; }
       public bool Activo { get; set; }
    }
    }
