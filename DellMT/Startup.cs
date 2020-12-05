using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DellMT.Startup))]
namespace DellMT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
