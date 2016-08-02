using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
namespace WebApiFrame
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
        public  void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }
    }
}