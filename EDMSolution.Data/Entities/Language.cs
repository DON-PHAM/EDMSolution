﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class Language
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }
        public Nullable<long> MaDonViSuDung { get; set; }
    }
}
