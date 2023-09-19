using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Websitebandoannhanh.Startup))]
namespace Websitebandoannhanh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
