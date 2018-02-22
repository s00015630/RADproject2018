using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RADproject2018.Startup))]
namespace RADproject2018
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
