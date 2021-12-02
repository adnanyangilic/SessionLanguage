using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SessionLanguage.Startup))]
namespace SessionLanguage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
