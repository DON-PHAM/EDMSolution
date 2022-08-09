﻿using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Footer
    {
        public int ID { set; get; }
        public string Contents { set; get; }
        public Status Status { set; get; }
    }
}
