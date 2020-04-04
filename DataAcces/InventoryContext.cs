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
                options.UseSqlServer("Server=LOCKED-ACER; Database=InventoryDb; User Id=sa; Password=toor");
            }
        }
    }
}
