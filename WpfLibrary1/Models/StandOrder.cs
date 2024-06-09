using WpfLibrary1.Models;

namespace AutoSalonWPF.Models
{
    public class StandOrder : Order
    {
        public decimal CalculateStandOrderCost()
        {
            return CalculateTotalCost();
        }
    }
}
