using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LIT.Startup))]
namespace LIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
