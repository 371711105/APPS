using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Apps.Startup))]
namespace Apps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
