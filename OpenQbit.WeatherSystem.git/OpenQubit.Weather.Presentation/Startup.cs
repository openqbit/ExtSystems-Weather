using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenQubit.Weather.Presentation.Startup))]
namespace OpenQubit.Weather.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
