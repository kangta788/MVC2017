using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_DataBaseContext.Models;

namespace MVC_DataBaseContext.DAL
{
    public class OperaContext:DbContext
    {
        public DbSet<Opera> Operas { get; set; }
    }
}