using Microsoft.Owin;
using Owin;
using SFS.Salao.UI.MVC;

[assembly: OwinStartup(typeof (Startup))]

namespace SFS.Salao.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}