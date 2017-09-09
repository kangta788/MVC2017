using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_DataBaseContext.Models;
using System.Data.Entity;

namespace MVC_DataBaseContext.DAL
{
    public class OperasInitialzer:DropCreateDatabaseAlways<OperaContext>
    {

        protected override void Seed(OperaContext context)
        {
            base.Seed(context);
            context.Operas.Add(new Opera() { Title = "芝加哥", Year = 1975, Composer = "Maurine Dallas Watkins" });
            context.Operas.Add(new Opera() { Title = "悲慘世界", Year =1980 , Composer = "克勞德-米歇爾·勛伯格" });
            context.Operas.Add(new Opera() { Title = "歌劇魅影", Year = 1986, Composer = "安德魯·洛伊·韋伯" });
            context.Operas.Add(new Opera() { Title = "貓", Year = 1981, Composer = "安德魯·洛伊·韋伯" });

            context.SaveChanges();
        }



    }
}