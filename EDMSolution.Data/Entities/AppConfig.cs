﻿using EDMSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMSolution.Data.Entities
{
    public class AppConfig
    {
        public string Key { set; get; }
        public string Value { set; get; }
        public Nullable<long> MaDonViSuDung { set; get; }
    }
}
