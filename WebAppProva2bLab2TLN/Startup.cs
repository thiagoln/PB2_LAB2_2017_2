using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppProva2bLab2TLN.Startup))]
namespace WebAppProva2bLab2TLN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
