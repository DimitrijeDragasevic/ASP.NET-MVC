using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp_mvc.Startup))]
namespace asp_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
