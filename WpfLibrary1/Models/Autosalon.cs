using System.Collections.Generic;

namespace AutoSalonWPF.Models
{
    public class Autosalon
    {
        public string Name { get; set; }
        public List<Automobile> Automobiles { get; set; } = new List<Automobile>();
    }
}
