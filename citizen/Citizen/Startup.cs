using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Citizen.Startup))]
namespace Citizen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
