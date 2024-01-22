using Guide.Variacao.Core.Domain.Models;

namespace Guide.Variacao.Core.Domain.ViewModels
{
    public class AuctionViewModel : BaseViewModel
    {
        public StockViewModel Stock = new ();
        public DateTime TimeStamp { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
    }
}
