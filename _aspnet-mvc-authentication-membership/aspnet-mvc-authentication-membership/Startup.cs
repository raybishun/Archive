using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnet_mvc_authentication_membership.Startup))]
namespace aspnet_mvc_authentication_membership
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
