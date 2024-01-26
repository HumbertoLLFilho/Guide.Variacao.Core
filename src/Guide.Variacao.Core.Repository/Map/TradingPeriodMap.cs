using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Guide.Variacao.Core.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Guide.Variacao.Core.DataBase.Map
{
    public class TradingPeriodMap : BaseModelMap<TradingPeriod>, IEntityTypeConfiguration<TradingPeriod>
    {
        public void Configure(EntityTypeBuilder<TradingPeriod> builder)
        {
            base.Configure(builder);
        }
    }
}
