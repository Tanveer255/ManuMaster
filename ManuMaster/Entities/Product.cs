using Volo.Abp.Domain.Entities;

namespace ManuMaster.Entities
{
    public class Product : BasicAggregateRoot<Guid>
    {
        public string Text { get; set; } = string.Empty;
        public double Price { get; set; } = 0.0;
        public int Quantity { get; set; } = 0;
        public DateTime Manufactured { get; set; } = DateTime.UtcNow;
        public DateTime EntryDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    }
}
