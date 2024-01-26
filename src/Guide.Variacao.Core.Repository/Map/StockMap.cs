using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Guide.Variacao.Core.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Guide.Variacao.Core.DataBase.Map
{
    public class StockMap : BaseModelMap<Stock>, IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasMany(e => e.Auctions)
                .WithOne();

            builder.HasMany(e => e.TradingPeriods)
                .WithOne();

            base.Configure(builder);
        }
    }
}
