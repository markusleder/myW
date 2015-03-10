using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MyW.Startup))]

namespace MyW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
