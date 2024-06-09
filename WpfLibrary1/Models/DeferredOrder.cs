namespace AutoSalonWPF.Models
{
    public class DeferredOrder : Order
    {
        public decimal DiscountPercentage { get; set; }

        public decimal CalculateDeferredOrderCost()
        {
            return CalculateTotalCost() * (1 - DiscountPercentage / 100);
        }
    }
}
