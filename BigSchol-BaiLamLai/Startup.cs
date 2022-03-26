using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchol_BaiLamLai.Startup))]
namespace BigSchol_BaiLamLai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
