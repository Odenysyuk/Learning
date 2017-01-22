using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Introducing.Startup))]
namespace Introducing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
