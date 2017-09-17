using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNET_Identity.Startup))]
namespace ASPNET_Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
