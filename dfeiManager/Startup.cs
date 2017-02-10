using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dfeiManager.Startup))]
namespace dfeiManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
