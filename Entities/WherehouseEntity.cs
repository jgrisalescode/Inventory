﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class WherehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WherehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WherehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WherehouseAddress { get; set; }

        // Relación con almacenamiento (StorageEntity)
        public ICollection<StorageEntity> Storages { get; set; }
    }
}
