using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Restorant.Startup))]
namespace Restorant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
