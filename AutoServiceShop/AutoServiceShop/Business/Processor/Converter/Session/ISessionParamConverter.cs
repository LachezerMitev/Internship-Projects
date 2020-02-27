﻿using AutoServiceShop.Business.Processor.Converter.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Session
{
    public interface ISessionParamConverter : IBaseParamConverter<SessionParam, Data.Entity.SessionAPI>
    {
    }
}