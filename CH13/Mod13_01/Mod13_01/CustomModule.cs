using System;
using System.Web;

namespace Mod13_01
{
    public class CustomModule : IHttpModule
    {
        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //clean-up code here.
        }

        public void Init(HttpApplication context)
        {
            // Below is an example of how you can handle LogRequest event and provide 
            // custom logging implementation for it
            //1,
            //context.BeginRequest += new EventHandler(OnBeginRequest);
            //2,
            //context.BeginRequest += OnBeginRequest;
            //3,
            //context.BeginRequest += delegate (Object source, EventArgs e)
            //{
            //    HttpApplication app = (HttpApplication)source;
            //    string url = app.Context.Request.QueryString["url"];
            //    if (url != null)
            //    {
            //        app.Context.Response.Redirect(url);
            //    }
            //};
            //4,
            //context.BeginRequest += (Object source, EventArgs e) =>
            //{
            //    HttpApplication app = (HttpApplication)source;
            //    string url = app.Context.Request.QueryString["url"];
            //    if (url != null)
            //    {
            //        app.Context.Response.Redirect(url);
            //    }
            //};
            //5,
            context.BeginRequest += (source,  e) =>
            {
                string url = context.Context.Request.QueryString["url"];
                if (url != null)
                {
                    context.Context.Response.Redirect(url);
                }
            };
        }

        #endregion

        public void OnBeginRequest(Object source, EventArgs e)
        {
            HttpApplication app = (HttpApplication)source;
            string url = app.Context.Request.QueryString["url"];
            if (url != null)
            {
                app.Context.Response.Redirect(url);
            }

        }
    }
}
