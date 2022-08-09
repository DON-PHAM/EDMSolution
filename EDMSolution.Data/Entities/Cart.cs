﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Cart
    {
        public int Id { set; get; }
        public string ProductID { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
    }
}