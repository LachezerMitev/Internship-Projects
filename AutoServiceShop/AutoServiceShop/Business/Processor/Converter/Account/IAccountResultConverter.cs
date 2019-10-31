using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    interface IAccountResultConverter
    {
        AccountResult Convert(AutoServiceShop.Data.Entity.Account param);
    }
}
