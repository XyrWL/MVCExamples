using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxWebProject.Startup))]
namespace AjaxWebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
