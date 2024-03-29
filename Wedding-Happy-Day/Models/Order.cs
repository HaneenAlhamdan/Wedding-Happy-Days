﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Model.Services;

namespace Wedding_Happy_Day.Model
{
    public class Order
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }

        //  public List<OrderItem> OrderItems { get; set; }
    } 
}
