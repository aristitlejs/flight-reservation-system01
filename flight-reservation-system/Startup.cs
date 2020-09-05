using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(flight_reservation_system.Startup))]
namespace flight_reservation_system
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
