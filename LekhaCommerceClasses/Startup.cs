using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LekhaCommerceClasses.Startup))]
namespace LekhaCommerceClasses
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
