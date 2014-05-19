using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JpStore.Model.Products;
using JpStore.Infrastructure.Domain;


namespace JpStore.Services.Products
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _uow;

        public ProductService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Insert(Product entity)
        {
            _uow.Repository<Product>().Add(entity);
        }

        public void Update(Product entity)
        {
            _uow.Repository<Product>().Update(entity);
        }

        public void Delete(Product entity)
        {
            _uow.Repository<Product>().Remove(entity);
        }

        public Product GetBy(int Id)
        {
            return _uow.Repository<Product>().Get(p => p.Id == Id).Single();
        }

        public IEnumerable<Product> FindAll()
        {
            return _uow.Repository<Product>().FindAll();
        }

        public IEnumerable<Product> FindAllInBrand(int brandId)
        {
            return _uow.Repository<Product>().FindAll().Where(p => p.BrandId == brandId);
        }

        public IEnumerable<Product> FindAllInCategory(int categoryId)
        {
            return _uow.Repository<Product>().FindAll().Where(p => p.CategoryId == categoryId);
        }
    }
}
