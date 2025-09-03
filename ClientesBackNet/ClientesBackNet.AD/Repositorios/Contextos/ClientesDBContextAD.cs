using Microsoft.EntityFrameworkCore;

namespace ClientesBackNet.AD.Repositorios.Contextos
{

    public partial class ClientesDBContextAD : DbContext
    {
        public readonly string cadenaConexion;

        public ClientesDBContextAD(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cadenaConexion);
        }
    }
}
