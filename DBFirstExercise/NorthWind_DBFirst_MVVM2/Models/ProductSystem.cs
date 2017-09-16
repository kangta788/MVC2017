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

        public CategoryProductsViewModel GetProductsByCategoryID(int Id)
        {
            NorthwindEntities db = new NorthwindEntities();

            CategoryProductsViewModel result = new CategoryProductsViewModel();
            result.CategoryID = Id;
            result.CategoryName = db.Categories.Find(Id).CategoryName;
            result.Description = db.Categories.Find(Id).Description;

            var query = from p in db.Products
                        where p.CategoryID == Id
                        select new ProductViewModel { ProductID = p.ProductID, ProductName = p.ProductName, Price = p.UnitPrice };

            result.Products = query.ToList();

            return result;
        }

    }
}