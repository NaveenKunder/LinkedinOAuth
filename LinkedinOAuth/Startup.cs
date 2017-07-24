using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinkedinOAuth.Startup))]
namespace LinkedinOAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
