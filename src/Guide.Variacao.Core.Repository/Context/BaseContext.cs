using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace Guide.Variacao.Core.DataBase.Context
{
    public class BaseContext<T> : DbContext where T : DbContext
    {
        public BaseContext(DbContextOptions<T> options) : base(options)
        {
            Database.SetCommandTimeout(3000);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            // Unicode
            builder.Properties<string>().AreUnicode(false);
            builder.Properties<List<string>>().AreUnicode(false);
            builder.Properties<Dictionary<string, string>>().AreUnicode(false);

            // Conversions
            builder.Properties<Dictionary<string, int>>().HaveConversion<JsonConverter<Dictionary<string, int>>>();
            builder.Properties<Dictionary<string, string>>().HaveConversion<JsonConverter<Dictionary<string, string>>>();

            base.ConfigureConventions(builder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }


    }
}
