using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding_Happy_Day.Model
{
    public class Hall
    {
        public int Id { get; set; }

        [Display(Name = "Beauty_Center Name")]
        [Required(ErrorMessage = "Beauty_Center name is required")]
        public string Name { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public double Price { get; set; }
        public string Address { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Beauty_Center description is required")]
        public string Description { get; set; }

        [Display(Name = "Beauty_Center Logo")]
        [Required(ErrorMessage = "Beauty_Center logo is required")]
        public string Logo { get; set; }
    }
}
