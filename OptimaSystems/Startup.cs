using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OptimaSystems.Startup))]
namespace OptimaSystems
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
