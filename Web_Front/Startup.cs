using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Front.Startup))]
namespace Web_Front
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();//SignalR
            ConfigureAuth(app);
        }
    }
}
