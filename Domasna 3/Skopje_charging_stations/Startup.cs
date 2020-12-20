using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Skopje_charging_stations.Startup))]
namespace Skopje_charging_stations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
