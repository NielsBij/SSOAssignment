using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSOAssignmentPoC.Startup))]
namespace SSOAssignmentPoC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
