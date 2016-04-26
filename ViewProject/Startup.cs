using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewProject.Startup))]
namespace ViewProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
