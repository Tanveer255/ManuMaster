namespace ManuMaster.Services.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public double Price { get; set; } = 0.0;
        public int Quantity { get; set; } = 0;
        public DateTime Manufactured { get; set; } = DateTime.UtcNow;
        public DateTime EntryDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    }
}
