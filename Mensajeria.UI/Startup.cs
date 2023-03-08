using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mensajeria.UI.Startup))]
namespace Mensajeria.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
