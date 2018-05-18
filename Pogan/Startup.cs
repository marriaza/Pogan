using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pogan.Startup))]
namespace Pogan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
