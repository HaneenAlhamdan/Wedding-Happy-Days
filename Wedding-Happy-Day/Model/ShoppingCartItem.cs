using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding_Happy_Day.Model
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }

        public Beauty_Center BeautyCenter { get; set; }
        public int BeautyCenterId { get; set; }

        public int Amount { get; set; }


        public string ShoppingCartId { get; set; }
    }
}
