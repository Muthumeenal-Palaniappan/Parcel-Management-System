using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParcelManagementApp.Startup))]
namespace ParcelManagementApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
