using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShrimpFarm.Startup))]
namespace MyShrimpFarm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
