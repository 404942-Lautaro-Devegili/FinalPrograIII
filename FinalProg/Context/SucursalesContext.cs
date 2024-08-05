using FinalProg.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProg.Context
{
    public class SucursalesContext : DbContext
    {
        public SucursalesContext(DbContextOptions<SucursalesContext> options) : base(options)
        {
        }

        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Configuracion> Configuraciones { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<TipoSucursal> TiposSucursal { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=UserConnectionStrings");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provincia>().HasData(
                               new Provincia { Id = Guid.NewGuid(), Nombre = "Buenos Aires" },
                               new Provincia { Id = Guid.NewGuid(), Nombre = "Córdoba" },
                               new Provincia { Id = Guid.NewGuid(), Nombre = "Salta" }
                               );

            modelBuilder.Entity<TipoSucursal>().HasData(
                               new TipoSucursal { Id = Guid.NewGuid(), Nombre = "Pequeña" },
                               new TipoSucursal { Id = Guid.NewGuid(), Nombre = "Grande" }
                               );

            modelBuilder.Entity<Configuracion>().HasData(
                               new Configuracion { Id = Guid.NewGuid(), Nombre = "padding-top", Valor = "50px" },
                               new Configuracion { Id = Guid.NewGuid(), Nombre = "padding-left", Valor = "100px" }
                               );

            modelBuilder.Entity<Sucursal>()
                .HasOne<TipoSucursal>(s => s.TipoSucursal)
                .WithMany(t => t.Sucursales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasForeignKey(s => s.IdTipo);

            modelBuilder.Entity<Sucursal>()
                .HasOne<Provincia>(s => s.Provincia)
                .WithMany(p => p.Sucursales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasForeignKey(s => s.IdProvincia);



            base.OnModelCreating(modelBuilder);

        }


    }
    
    
}
