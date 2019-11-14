﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.AutoPart
{
    class AutoPartParam : BaseParamNamed
    {
        public long AutoPartStatusId { get; set; }

        public string AutoPartName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}
