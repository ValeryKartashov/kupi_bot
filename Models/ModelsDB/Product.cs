namespace KupiCore.Models.ModelsDB
{
    public partial class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string? Image { get; set; } = null!;
    }
}
