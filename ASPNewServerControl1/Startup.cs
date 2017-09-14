using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNewServerControl1.Startup))]
namespace ASPNewServerControl1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
