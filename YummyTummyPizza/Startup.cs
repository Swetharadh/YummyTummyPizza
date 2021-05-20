using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YummyTummyPizza.Startup))]
namespace YummyTummyPizza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
