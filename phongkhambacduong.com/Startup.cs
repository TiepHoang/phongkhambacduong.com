using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(phongkhambacduong.com.Startup))]
namespace phongkhambacduong.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
