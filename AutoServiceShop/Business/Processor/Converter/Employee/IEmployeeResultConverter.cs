using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Employee
{
    interface IEmployeeResultConverter
    {
        EmployeeResult Convert(AutoServiceShop.Data.Entity.Employee param);
    }
}
