using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentricRecognition9.Startup))]
namespace CentricRecognition9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
