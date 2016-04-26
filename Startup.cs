using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Areas.Startup))]
namespace Areas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
