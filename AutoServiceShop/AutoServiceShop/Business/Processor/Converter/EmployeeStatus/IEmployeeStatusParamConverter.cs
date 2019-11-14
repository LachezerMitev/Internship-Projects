using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.EmployeeStatus
{
    interface IEmployeeStatusParamConverter
    {
        AutoServiceShop.Data.Entity.EmployeeStatus Convert(EmployeeStatusParam param, Data.Entity.EmployeeStatus oldentity);
    }
}
