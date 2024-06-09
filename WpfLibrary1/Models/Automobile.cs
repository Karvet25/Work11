namespace AutoSalonWPF.Models
{
    public class Automobile
    {
        public string Brand { get; set; }
        public int MaxPassengers { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsAvailable { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
