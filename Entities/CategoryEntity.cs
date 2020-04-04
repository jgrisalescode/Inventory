using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class CategoryEntity
    {
        [Key] // Nuestra Llave primaria
        [StringLength(50)]
        public string CategoryId { get; set; }

        [Required] // Obligatorio
        [StringLength(100)]
        public string CategoryName { get; set; }

    }
}
