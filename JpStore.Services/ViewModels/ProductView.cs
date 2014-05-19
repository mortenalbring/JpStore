using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JpStore.Services.ViewModels
{
    public class ProductView
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string ProductTitle { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
    }
}
