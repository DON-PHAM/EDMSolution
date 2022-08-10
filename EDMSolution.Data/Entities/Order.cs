﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Order
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int ProductID { set; get; }
        public Product Product { set; get; }
    }
}
