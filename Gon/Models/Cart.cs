using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Gon.Models
{
    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int? Userid { get; set; }
        public int Productid { get; set; }
        public int? Qty { get; set; }
        public int? Sissionid { get; set; }

        [ForeignKey(nameof(Productid))]
        [InverseProperty("Carts")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(Sissionid))]
        [InverseProperty(nameof(Session.Carts))]
        public virtual Session Sission { get; set; }
    }
}
