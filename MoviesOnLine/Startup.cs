using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesOnLine.Startup))]
namespace MoviesOnLine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
