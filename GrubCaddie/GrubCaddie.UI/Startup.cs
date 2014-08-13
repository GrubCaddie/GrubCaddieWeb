using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GrubCaddie.UI.Startup))]
namespace GrubCaddie.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
