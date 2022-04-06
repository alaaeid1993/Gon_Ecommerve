using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Gon.Models
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Price { get; set; }
        public int? Catid { get; set; }
        public string Photo { get; set; }
        public string Filepath { get; set; }
        [StringLength(50)]
        public string Fillter { get; set; }
        public byte[] Images { get; set; }

        [ForeignKey(nameof(Catid))]
        [InverseProperty(nameof(Category.Products))]
        public virtual Category Cat { get; set; }
        [InverseProperty(nameof(Cart.Product))]
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
