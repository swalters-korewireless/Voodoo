using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

namespace MovieAngularJSApp
{
    public class Startup
    {
        
        /// <summary>
        /// Used to register MVC with the build-in Dependency Injection framework included in ASP.NET 5
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddCaching();
            services.AddSession();
        }

        /// <summary>
        /// Used to register MVC with OWIN
        /// </summary>
        /// <param name="app"></param>
        public void Configure(IApplicationBuilder app)
        {
            app.UseSession();
            app.UseMvc();
        }

    }
}
