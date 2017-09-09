using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Empty.Models
{
    public class Opera
    {
        public int OperaID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Composer { get; set; }

        //資料也可來自資料庫
        //object First 非以往的Database first

    }
}