﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mod13_01
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        //protected void Application_BeginRequest()
        //{
        //    string url = Context.Request.QueryString["url"];
        //    if (url != null)
        //    {
        //        Context.Response.Redirect(url);
        //    }
        //}
    }
}
