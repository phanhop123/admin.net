using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebOnline.Startup))]
namespace WebOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
