using JpStore.Model.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JpStore.Services.Products
{
    public interface IProductService : IBaseService<Product>
    {
        Product GetBy(int Id);
        IEnumerable<Product> FindAll();
        IEnumerable<Product> FindAllInBrand(int brandId);
        IEnumerable<Product> FindAllInCategory(int categoryId);
    }
}
