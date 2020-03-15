using Microsoft.AspNetCore.Builder;

namespace Arenal.Dms.WebApp.Configuration
{
    public static class Cors
    {
        public static void CorsConfig(this IApplicationBuilder app)
        {
            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        }
    }
}