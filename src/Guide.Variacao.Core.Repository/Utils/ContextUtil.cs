using Guide.Variacao.Core.DataBase.Configurations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Guide.Variacao.Core.DataBase.Utils
{
    public static class ContextUtil
    {
        public static void Reset<T>(this IServiceProvider provider) where T : DbContext
        {
            var _context = provider.GetService<T>() ?? throw new ArgumentNullException(nameof(T));

            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
        }

        public static ServiceProvider CreateContext<T>(this IConfiguration builder) where T : DbContext
        {
            // Service Configuration
            var services = new ServiceCollection();

            // IConfiguration
            services.AddSingleton<IConfiguration>(builder);

            // Database Configuration
            services.ConfigureDbContext<T>(builder);

            // Service Building
            return services.BuildServiceProvider();
        }
    }
}
