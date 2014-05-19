using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using JpStore.Infrastructure.Domain;

namespace JpStore.Model.Products
{
    [Table("Category",Schema="Products")]
    public class Category : BaseEntity<int>
    {
        [Required(ErrorMessage = "Product title cannot be empty"), MaxLength(200)]
        public string Title { get; set; }
    }
}
