using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Gon.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public string Photo { get; set; }
        [StringLength(50)]
        public string Fillter { get; set; }

        [InverseProperty(nameof(Product.Cat))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
