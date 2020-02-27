using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Session
{
    public class SessionParam : BaseParamNamed
    {
        public long UserId { get; set; }

        public string Token { get; set; }
    }
}
