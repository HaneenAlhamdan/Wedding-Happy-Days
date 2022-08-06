using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding_Happy_Day.Model
{
    public class Wedding
    {
        public string GroomName { get; set; }
        public string BrideName { get; set; }
        public DateTime WeddingDate { get; set; }
        public double EstimatedAmountOfCosts { get; set; }
        public string Description { get; set; }


        public List<Beauty_Center> Beauty_Centers { get; set; }
        public List<Car_rental> Car_rentals { get; set; }
        public List<Design_Fashion> Design_Fashions { get; set; }
        public List<Flower_Shop> Flower_Shops { get; set; }
        public List<Food_buffet> Food_buffets { get; set; }
        public List<Hall> Halls { get; set; }
        
    }
}
