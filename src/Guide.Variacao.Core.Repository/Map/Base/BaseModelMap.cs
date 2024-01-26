using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Guide.Variacao.Core.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Guide.Variacao.Core.DataBase.Map
{
    public class BaseModelMap<T> : IEntityTypeConfiguration<T> where T : BaseModel
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.ToTable("tb_" + typeof(T).Name.ToLower());

            builder.HasKey(t => t.Id);

            builder.HasQueryFilter(t => t.IsDeleted == false);
        }
    }
}
