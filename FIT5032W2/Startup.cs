using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT5032W2.Startup))]
namespace FIT5032W2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
