using Mod04_09.DAL;
using Mod04_09.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mod04_09.Models
{
    public class ProductSystem
    {

        public ProductViewModel GetProductByID(int Id)
        {
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.ProductID == Id
                        select new ProductViewModel { ProductID = p.ProductID, ProductName = p.ProductName, Price = p.UnitPrice };

            var result = query.First();
            return result;
        }

        public IEnumerable<Product> GetProductsByCategoryID(int Id)
        {
            NorthwindEntities db = new NorthwindEntities();
            var query = from p in db.Products
                        where p.CategoryID == Id
                        select p;

            var result = query.ToList();

            return result;
        }

    }
}