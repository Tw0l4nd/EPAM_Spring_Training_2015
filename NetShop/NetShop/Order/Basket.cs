﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetShop.Order
{
    public class Basket
    {
        public ICollection<BasketElement> Items { get; set; }
    }
}