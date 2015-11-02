using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projekt0._1.Startup))]
namespace projekt0._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
