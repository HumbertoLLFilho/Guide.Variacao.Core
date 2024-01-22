namespace Guide.Variacao.Core.Domain.Models
{
    public class Auction : BaseModel
    {
        public Guid StockId { get; set; }

        public DateTime TimeStamp { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
    }
}
