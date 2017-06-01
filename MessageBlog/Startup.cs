using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MessageBlog.Startup))]
namespace MessageBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
