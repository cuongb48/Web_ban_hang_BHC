using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBanHangOnlineBHC.Startup))]
namespace WebBanHangOnlineBHC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
