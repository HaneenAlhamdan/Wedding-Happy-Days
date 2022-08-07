using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding_Happy_Day.Model
{
    public class Wedding
    {


        [Display(Name = "GroomName Name")]
        [Required(ErrorMessage = "GroomName name is required")]
        public string GroomName { get; set; }


        [Display(Name = "BrideName Name")]
        [Required(ErrorMessage = "BrideName name is required")]
        public string BrideName { get; set; }


        public DateTime WeddingDate { get; set; }
        public double EstimatedAmountOfCosts { get; set; }

        [Display(Name = "Description Name")]
        [Required(ErrorMessage = "Description name is required")]
        public string Description { get; set; }


        public List<Beauty_Center> Beauty_Centers { get; set; }
        public List<Car_rental> Car_rentals { get; set; }
        public List<Design_Fashion> Design_Fashions { get; set; }
        public List<Flower_Shop> Flower_Shops { get; set; }
        public List<Food_buffet> Food_buffets { get; set; }
        public List<Hall> Halls { get; set; }
        
    }
}
