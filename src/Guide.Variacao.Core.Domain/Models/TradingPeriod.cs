using Guide.Variacao.Core.Domain.Enums;

namespace Guide.Variacao.Core.Domain.Models
{
    public class TradingPeriod : BaseModel
    {
        public Guid StockId { get; set; }

        public string TimeZone { get; set; }

        public TradingPeriodType Type { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public double Offset { get; set; }
    }
}
