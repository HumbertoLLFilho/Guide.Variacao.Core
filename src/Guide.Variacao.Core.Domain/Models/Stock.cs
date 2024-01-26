namespace Guide.Variacao.Core.Domain.Models
{
    public class Stock : BaseModel
    {
        public string Currency { get; set; }
        public string Symbol { get; set; }
        public string DataGranularity { get; set; }
        public string Range { get; set; }

        public List<Auction> Auctions { get; set; } = [];
        public List<TradingPeriod> TradingPeriods { get; set; } = [];
    }
}
