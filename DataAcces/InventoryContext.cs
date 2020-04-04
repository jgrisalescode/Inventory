using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Es necesario agregar EntityFramework en esta instancia
/// Ve a Dependiacias click derecho, Nuget y buscas el Framework sino esta instalado y lo 
/// agregas, el que se se agregó aqui fue EntityFramework 3.1.3
/// </summary>
namespace DataAcces
{
    public class InventoryContext : DbContext
    {
        // Le digo a EntityFramework que tablas va a tener
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }

        // Conexión a BD en SQLServer
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Creamos la cadena de conexión, nos aseugramos que no esta creada en otra parte
            if (!options.IsConfigured)
            {
                // Busca en el gestor de paquetes el conector para el Framwork de SQLServer
                /*
                 * connectionString
                 * Server=[SERVERNAME]; Database=InventoryDb; User Id=[USER]; Password=[PASSWORD]
                 */
                options.UseSqlServer(DataAccessConfig.connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Alimentamos con datos dummy para tener con que trabajar
            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar"},
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal"},
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar"},
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumería"},
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud"},
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos"}
                );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Central", WarehouseAddress = "Calle Mayor"},
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Norte", WarehouseAddress = "Calle Palma"},
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Sur", WarehouseAddress = "Calle Menor"}
                );
        }
    }
}
