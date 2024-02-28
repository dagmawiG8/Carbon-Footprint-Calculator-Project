using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarbonFoorPrintCalculator.Startup))]
namespace CarbonFoorPrintCalculator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
