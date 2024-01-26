using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Guide.Variacao.Core.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Guide.Variacao.Core.DataBase.Map
{
    public class AuctionMap : BaseModelMap<Auction>, IEntityTypeConfiguration<Auction>
    {
        public void Configure(EntityTypeBuilder<Auction> builder)
        {
            base.Configure(builder);
        }
    }
}
