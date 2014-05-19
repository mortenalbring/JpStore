using JpStore.Infrastructure.Domain;
using JpStore.Repository;
using JpStore.Services.Products;
using StructureMap;
using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JpStore.UI
{
    public class BootStrapper
    {
        public static void ConfigureDependecies()
        {
            ObjectFactory.Initialize(x =>
            {
                x.AddRegistry<ControllerRegistry>();
            });
        }

        public class ControllerRegistry : Registry
        {
            public ControllerRegistry()
            {
                For<IDbContext>().Use<DataContext>();
                For<IUnitOfWork>().Use<UnitOfWork>();
                For<IProductService>().Use<ProductService>();                
            }
        }
    }
}