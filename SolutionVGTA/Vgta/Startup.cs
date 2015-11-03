using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vgta.Startup))]
namespace Vgta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
