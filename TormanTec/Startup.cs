using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TormanTec.Startup))]
namespace TormanTec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
