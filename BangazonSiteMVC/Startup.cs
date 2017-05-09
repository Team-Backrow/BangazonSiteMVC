using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BangazonSiteMVC.Startup))]
namespace BangazonSiteMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
