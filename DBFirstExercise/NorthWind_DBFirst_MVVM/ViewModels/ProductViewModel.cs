using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mod04_09.ViewModels
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
    }
}