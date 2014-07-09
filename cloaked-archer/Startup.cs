using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cloaked_archer.Startup))]
namespace cloaked_archer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
