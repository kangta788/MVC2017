using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_DataBaseContext.Models;

namespace MVC_DataBaseContext.DAL
{
    //繫結資料庫
    //connectionString="Data Source=.\SqlExpress;Initial Catalog=MyOperaDB;Integrated Security=True"
    public class OperasDB:DbContext
    {
        public DbSet<Opera> Operas { get; set; }

        //會在DB中建立一個Table,名稱為Operas
    }

    

    //DB初始化動作 因為會一直使用
    public class OperasDB_Initialzer : DropCreateDatabaseAlways<OperasDB> //還有別種可用
    {

        protected override void Seed(OperasDB context)
        {
            base.Seed(context);
            context.Operas.Add(new Opera() { Title = "芝加哥", Year = 1975, Composer = "Maurine Dallas Watkins" });
            context.Operas.Add(new Opera() { Title = "悲慘世界", Year = 1980, Composer = "克勞德-米歇爾·勛伯格" });
            context.Operas.Add(new Opera() { Title = "歌劇魅影", Year = 1986, Composer = "安德魯·洛伊·韋伯" });
            context.Operas.Add(new Opera() { Title = "貓", Year = 1981, Composer = "安德魯·洛伊·韋伯" });

            context.SaveChanges();
        }



    }
}