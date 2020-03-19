using Arenal.Dms.Domain.Entities;
using Arenal.Dms.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Arenal.Dms.Domain
{
    public static class DatabaseConfig
    {
        public static void DbConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ArenalDms"));
                options.EnableSensitiveDataLogging();
                options.EnableDetailedErrors();
            });
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}