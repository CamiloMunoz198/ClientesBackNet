using ClientesBackNet.AD.Repositorios.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ClientesBackNet.AD.Repositorios.Contextos
{
    public partial class ClientesDBContextAD: DbContext
    {
        public virtual DbSet<Clientes> Clientes { get; set; }
    }
}
