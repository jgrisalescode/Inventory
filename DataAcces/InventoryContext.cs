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
    }
}
