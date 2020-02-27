using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Session
{
    public class SessionResultConverter : BaseResultConverter<Data.Entity.SessionAPI, SessionResult>, ISessionResultConverter
    {
        public override void ConvertSpecific(SessionAPI param, SessionResult result)
        {
        }
    }
}
