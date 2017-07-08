using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIUNIVERSIDAD.Web.Startup))]
namespace MIUNIVERSIDAD.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
