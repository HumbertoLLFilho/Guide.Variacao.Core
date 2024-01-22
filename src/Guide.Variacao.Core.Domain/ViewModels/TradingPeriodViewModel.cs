using Guide.Variacao.Core.Domain.Enums;

namespace Guide.Variacao.Core.Domain.ViewModels
{
    public class TradingPeriodViewModel : BaseViewModel
    {
        public string TimeZone { get; set; }

        public TradingPeriodType Type { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public double Offset { get; set; }
    }
}
