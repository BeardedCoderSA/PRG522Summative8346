using Microsoft.Owin;
using Owin;
using System.Web.Services.Description;
using System.Data.Sql;
using System.Data.SqlClient;

[assembly: OwinStartupAttribute(typeof(PRG522Summative8346.Startup))]
namespace PRG522Summative8346
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
}
    }
}
