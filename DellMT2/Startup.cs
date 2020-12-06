using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DellMT2.Startup))]
namespace DellMT2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
