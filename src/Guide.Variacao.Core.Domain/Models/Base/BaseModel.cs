namespace Guide.Variacao.Core.Domain.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            Id = Guid.NewGuid();
            IsDeleted = false;
            CreatedAt = DateTime.Now;
            ModifiedAt = DateTime.Now;
        }

        public Guid Id { get; }

        public bool IsDeleted { get; set; }

        public DateTime? ModifiedAt { get; set; }
        public DateTime? CreatedAt { get; }
    }
}
