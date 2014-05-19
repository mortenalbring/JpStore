using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JpStore.Infrastructure.Domain;

namespace JpStore.Model.Products
{
    [Table("Product",Schema="Products")]
    public class Product : BaseEntity<int>
    {
        [Required(ErrorMessage="Product title cannot be empty"),MaxLength(200)]
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        [Required(ErrorMessage = "Cost cannot be empty"), Range(typeof(decimal), "0.0", "79228162514264337593543950335", ErrorMessage = "Decimal numbers only")]
        public decimal Price { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<ProductImages> ProductImages { get; set; }
    }
}
