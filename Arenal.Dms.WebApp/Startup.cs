using Arenal.Dms.Core;
using Arenal.Dms.Domain;
using Arenal.Dms.WebApp.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Arenal.Dms.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.DbConfig(Configuration);
            services.JwtConfig(Configuration);
            services.SwaggerConfig();
            services.ServicesDependencyInjection();
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseRouting();
            app.SwaggerBuilder();
            app.CorsConfig();
            app.UseAuthentication();
            app.UseAuthorization();
            app.DatabaseExceptionConfiguration();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}