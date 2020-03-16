using AutoServiceShop.Business.Processor.Converter.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Session
{
    public interface ISessionResultConverter : IBaseResultConverter<Data.Entity.SessionAPI, SessionResult>
    {
    }
}
