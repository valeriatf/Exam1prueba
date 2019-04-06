using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_prueba.Startup))]
namespace Web_prueba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
