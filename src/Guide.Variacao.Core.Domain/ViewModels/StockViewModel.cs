using Guide.Variacao.Core.Domain.Models;

namespace Guide.Variacao.Core.Domain.ViewModels
{
    public class StockViewModel : BaseViewModel
    {
        public string Currency { get; set; }
        public string Symbol { get; set; }
        public string DataGranularity { get; set; }
        public string Range { get; set; }

        public List<AuctionViewModel> AuctionsViewModel { get; set; } = [];
        public List<TradingPeriodViewModel> TradingPeriodsViewModel { get; set; } = [];
    }
}
