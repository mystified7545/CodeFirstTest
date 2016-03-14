using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bizweiser.Startup))]
namespace Bizweiser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
