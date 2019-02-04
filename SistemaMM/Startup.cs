using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaMM.Startup))]
namespace SistemaMM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
