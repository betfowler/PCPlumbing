using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCPlumbing.Startup))]
namespace PCPlumbing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
