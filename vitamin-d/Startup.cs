using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vitamin_d.Startup))]
namespace vitamin_d
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
