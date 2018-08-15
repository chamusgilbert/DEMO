using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoBI.Startup))]
namespace DemoBI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
