using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(partyTime.Startup))]
namespace partyTime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
