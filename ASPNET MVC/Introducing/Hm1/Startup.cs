using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hm1.Startup))]
namespace Hm1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
