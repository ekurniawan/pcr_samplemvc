using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleEF.Startup))]
namespace SampleEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
