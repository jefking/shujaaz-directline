using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DirectLineBot.Startup))]
namespace DirectLineBot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
