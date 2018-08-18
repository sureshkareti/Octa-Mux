using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OctaMux.Startup))]
namespace OctaMux
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
