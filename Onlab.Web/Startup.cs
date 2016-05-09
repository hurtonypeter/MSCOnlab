using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Onlab.Web.Startup))]
namespace Onlab.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
