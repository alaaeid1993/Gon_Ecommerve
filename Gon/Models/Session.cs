using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Gon.Models
{
    [Table("Session")]
    public partial class Session
    {
        public Session()
        {
            Carts = new HashSet<Cart>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(450)]
        public string UserId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }

        [InverseProperty(nameof(Cart.Sission))]
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
