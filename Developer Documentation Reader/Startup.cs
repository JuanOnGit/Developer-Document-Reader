using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Developer_Documentation_Reader.Startup))]
namespace Developer_Documentation_Reader
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
