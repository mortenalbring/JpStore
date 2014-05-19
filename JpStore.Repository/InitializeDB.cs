using JpStore.Model.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace JpStore.Repository
{
    public class InitializeDB : DropCreateDatabaseIfModelChanges<DataContext>//CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var brands = new List<Brand>
            {
                new Brand { Title = "Levis"},
                new Brand { Title = "Wrangler"},
                new Brand { Title = "Diesel"},
                new Brand { Title = "Tommy Hilfiger"},
                new Brand { Title = "Hugo Boss"},
                new Brand { Title = "Polo"}
            };

            new List<Category>
            {
                new Category { Title = "Jeans"},
                new Category { Title = "Shirts"}
            }.ForEach(s => context.Set<Category>().Add(s));
        }
    }
}
