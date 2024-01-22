using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Guide.Variacao.Core.DataBase.Configurations
{
    public static class PGSqlConfiguration
    {
        public static IServiceCollection ConfigureDbContext<T>(this IServiceCollection services, IConfiguration configuration) where T : DbContext
        {
            ArgumentNullException.ThrowIfNull(services);

            var connectionStirng = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionStirng))
                throw new FileNotFoundException("\"DefaultConnection\" string was not found in \"Appsettings.json\"");

            services.AddEntityFrameworkNpgsql();

            services.AddDbContext<T>(o =>
                o.UseNpgsql(connectionStirng)
            );

            return services;
        }
    }
}
