using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AMEL2.Startup))]
namespace AMEL2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
