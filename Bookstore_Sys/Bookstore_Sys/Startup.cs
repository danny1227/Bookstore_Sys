using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bookstore_Sys.Startup))]
namespace Bookstore_Sys
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
