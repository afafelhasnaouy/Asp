using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlateformeConcours.Startup))]
namespace PlateformeConcours
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
