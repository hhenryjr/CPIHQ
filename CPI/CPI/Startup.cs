using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CPI.Startup))]
namespace CPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
