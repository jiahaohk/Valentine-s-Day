using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Valentine_s_Day.Startup))]
namespace Valentine_s_Day
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
