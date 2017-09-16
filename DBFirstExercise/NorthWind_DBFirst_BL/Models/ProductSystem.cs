using Mod04_09.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mod04_09.Models
{
    public class ProductSystem
    {

        public Product GetProductByID(int Id)
        {
            NorthwindEntities db = new NorthwindEntities();
            var result = db.Products.Find(Id);

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