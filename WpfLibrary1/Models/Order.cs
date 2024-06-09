using System.Collections.Generic;
using WpfLibrary1.Models;

namespace AutoSalonWPF.Models
{
    public class Order
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Automobile> Automobiles { get; set; } = new List<Automobile>();

        public decimal CalculateTotalCost()
        {
            decimal total = 0;
            foreach (var car in Automobiles)
            {
                total += car.Price;
            }
            return total;
        }
    }
}
