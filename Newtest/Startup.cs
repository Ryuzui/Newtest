using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Newtest.Startup))]
namespace Newtest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
