using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JpStore.Infrastructure.Domain;

namespace JpStore.Model.Products
{
    [Table("ProductImages",Schema="Products")]
    public class ProductImages : BaseEntity<int>
    {
        [Required, MaxLength(250)]
        public string ImagePath { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
