using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWepApi.Startup))]
namespace MvcWepApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
