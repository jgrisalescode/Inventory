using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string ProductId { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }
        [StringLength(600)]
        public string ProductDescription { get; set; }
        public int TotalQuantity { get; set; }

        // Relación con categorías (CategoryEntity)
        public string CaregoryId { get; set; } // PK de (CategoryEntity)
        public CategoryEntity Category { get; set; } // Navegación

        // Relación con almacenamiento (SotorageEntity)
        public ICollection<StorageEntity> Storages { get; set; } // Navegación
    }
}
