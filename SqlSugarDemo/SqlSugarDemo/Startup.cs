using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SqlSugarDemo.Startup))]
namespace SqlSugarDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
