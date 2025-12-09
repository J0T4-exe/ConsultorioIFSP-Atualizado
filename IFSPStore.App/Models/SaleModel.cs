using IFSPStore.Domain.Entities;

namespace IFSPStore.App.Models
{
    public class SaleModel
    {
        public SaleModel() 
        {
            Itens = new List<SaleItemModel>();
        }
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal SaleTotal { get; set; }
        public decimal Quantity { get; set; }
        public int IdUser { get; set; }
        public string User{ get; set; }
        public UserModel Salesman { get; set; }
        public int IdCustomer { get; set; }
        public string Customer { get; set; }
        public List<SaleItemModel> Itens { get; set; }
    }
    public class SaleItemModel
    {
        public int Id { get; set; }
        public decimal Quantity { get; set; }
        public string? Product { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int IdProduct { get; set; }
        public string? SaleUnit { get; set; }
    }
}
