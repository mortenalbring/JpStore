using AutoMapper;
using JpStore.Model.Products;
using JpStore.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JpStore.Services.Mappings
{
    public static class ProductMapper
    {
        public static ProductView ConvertToProductView(this Product product)
        {
            return Mapper.Map<Product, ProductView>(product);
        }
    }
}
