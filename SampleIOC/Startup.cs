using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleIOC.Startup))]
namespace SampleIOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
