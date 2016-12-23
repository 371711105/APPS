using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnityDemo.Startup))]
namespace UnityDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
