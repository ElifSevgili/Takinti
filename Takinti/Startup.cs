using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Takinti.Startup))]
namespace Takinti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
