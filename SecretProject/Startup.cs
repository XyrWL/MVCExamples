using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecretProject.Startup))]
namespace SecretProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
