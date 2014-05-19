using JpStore.Model.Products;
using JpStore.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace JpStore.Controllers.Products
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        public ActionResult Index()
        {
            var products = new List<Product>();
            products = _productService.FindAll().ToList();
            return View(products);
        }
    }
}
