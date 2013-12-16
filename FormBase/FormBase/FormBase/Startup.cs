using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FormBase.Startup))]
namespace FormBase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
