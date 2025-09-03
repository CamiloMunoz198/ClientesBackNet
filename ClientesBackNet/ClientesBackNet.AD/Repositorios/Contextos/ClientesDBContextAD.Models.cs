using ClientesBackNet.AD.Repositorios.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace ClientesBackNet.AD.Repositorios.Contextos
{
    public partial class ClientesDBContextAD : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.Property(e => e.Identificacion).ValueGeneratedNever();
            });
        }
    }
}
