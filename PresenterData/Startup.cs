using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PresenterData.Startup))]
namespace PresenterData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }


    }
}
