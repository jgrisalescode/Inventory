using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }
        
        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }

        // Relación con prodtos (ProductEntity)
        public string ProductId { get; set; } // La FK con el mismo nombre de la PK
        public ProductEntity Product { get; set; } // Navegación

        // Relación con bodegas (WherehouseEntity)
        public string WherehouseId { get; set; } // La FK con el mismo nombre de la PK
        public WherehouseEntity Wherehouse { get; set; } // Navegación

        // Relacion con salidas y entradas (InputOutputEntity)
        public ICollection<InputOutputEntity> InputOutputs { get; set; }
    }
}
