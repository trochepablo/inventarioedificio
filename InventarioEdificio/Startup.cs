using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InventarioEdificio.Startup))]
namespace InventarioEdificio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
