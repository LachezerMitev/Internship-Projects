using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.EmployeeStatus
{
    class EmployeeStatusResultConverter : BaseResultConverter<Data.Entity.EmployeeStatus, EmployeeStatusResult>, IEmployeeStatusResultConverter
    {
        public EmployeeStatusResult Convert(Data.Entity.EmployeeStatus param)
        {
            EmployeeStatusResult result = new EmployeeStatusResult();

            ConverterStandart(param, result);

            return result;
        }

        public override EmployeeStatusResult ConvertSpecific(Data.Entity.EmployeeStatus param, EmployeeStatusResult result)
        {
            throw new NotImplementedException();
        }
    }
}
