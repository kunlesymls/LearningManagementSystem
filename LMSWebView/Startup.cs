using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LMSWebView.Startup))]
namespace LMSWebView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
