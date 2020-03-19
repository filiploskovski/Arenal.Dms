using Arenal.Dms.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Arenal.Dms.Core
{
    public static class ServicesDI
    {
        public static void ServicesDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IDocumentTypeService, DocumentTypeService>();
        }
    }
}