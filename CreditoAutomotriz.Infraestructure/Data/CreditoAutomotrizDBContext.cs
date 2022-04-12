using CreditoAutomotriz.Entities;
using CreditoAutomotriz.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoAutomotriz.Infraestructure.Data
{
    public class CreditoAutomotrizDBContext : DbContext
    {
        public CreditoAutomotrizDBContext(DbContextOptions<CreditoAutomotrizDBContext> options) : base(options)
        {
        }
        public DbSet<UserCreateModel> clientes { get; set; }
        public DbSet<EjecutivosEntity> empleados { get; set; }
        public DbSet<MarcaModel> marcasVehiculos { get; set; }
        public DbSet<PatioCreateModel> patioAutos { get; set; }
        public DbSet<VehiculoCreateModel> autos { get; set; }
        public DbSet<AsignacionClienteModel> patio_cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserCreateModel>()
               .HasKey(x => new { x.idCliente });
            
            modelBuilder.Entity<EjecutivosEntity>()
               .HasKey(x => new { x.idEmpleado });

            modelBuilder.Entity<MarcaModel>()
               .HasKey(x => new { x.idMarca });

            modelBuilder.Entity<PatioCreateModel>()
               .HasKey(x => new { x.idPatio });

            modelBuilder.Entity<VehiculoCreateModel>()
              .HasKey(x => new { x.idAuto });

            modelBuilder.Entity<AsignacionClienteModel>()
              .HasKey(x => new { x.idPatioCliente });
        }
    }
}
