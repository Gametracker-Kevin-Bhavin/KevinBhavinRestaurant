using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KevinBhavinRestaurant.Startup))]
namespace KevinBhavinRestaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
