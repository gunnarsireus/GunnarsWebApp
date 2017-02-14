using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GunnarsWebApp.Startup))]
namespace GunnarsWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
