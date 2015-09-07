using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcShauli.Startup))]
namespace MvcShauli
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
