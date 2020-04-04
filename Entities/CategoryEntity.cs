using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class CategoryEntity
    {
        [Key] // Nuestra Llave primaria
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
