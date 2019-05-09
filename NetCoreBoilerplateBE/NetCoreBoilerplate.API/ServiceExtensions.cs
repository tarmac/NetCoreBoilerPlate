using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreBoilerplate.Contracts;
using NetCoreBoilerplate.Entities;
using NetCoreBoilerplate.LoggerService;
using NetCoreBoilerplate.Repository;
using NetCoreBoilerPlate.Repo.Definition;

namespace NetCoreBoilerplate.API
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionString:FirstExampleDB"];
            services.AddDbContext<RepositoryContext>(o => o.UseSqlServer(connectionString));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}