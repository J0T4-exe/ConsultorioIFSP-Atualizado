namespace IFSPStore.App.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string? SalesUnit { get; set; }
        public string? Category { get; set; }
        public int IdCategory { get; set; }

    }
}
