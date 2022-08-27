using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoIndividualUserAcc.Startup))]
namespace DemoIndividualUserAcc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
