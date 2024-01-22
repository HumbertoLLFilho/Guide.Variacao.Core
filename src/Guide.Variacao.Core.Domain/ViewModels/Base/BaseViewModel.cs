namespace Guide.Variacao.Core.Domain.ViewModels
{
    public class BaseViewModel
    {
        public Guid Id { get; set; }

        public DateTime? ModifiedAt { get; set; }
        public DateTime? CreatedAt { get; }
    }
}
