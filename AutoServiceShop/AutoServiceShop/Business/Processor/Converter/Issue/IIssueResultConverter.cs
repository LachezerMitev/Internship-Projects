﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Issue
{
    interface IIssueResultConverter
    {
        IssueResult Convert(AutoServiceShop.Data.Entity.Issue param);
    }
}
