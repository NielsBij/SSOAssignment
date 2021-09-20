using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSOAssignmentOAuth.Startup))]
namespace SSOAssignmentOAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
