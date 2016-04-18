using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoutingProject.Startup))]
namespace RoutingProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
