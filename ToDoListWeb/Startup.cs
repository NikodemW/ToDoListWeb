using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoListWeb.Startup))]
namespace ToDoListWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
