using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Employee
{
    class EmployeeResultConverter : BaseResultConverter<Data.Entity.Employee, EmployeeResult>, IEmployeeResultConverter
    {
        public EmployeeResult Convert(Data.Entity.Employee param)
        {
            EmployeeResult result = new EmployeeResult();

            ConverterStandart(param, result);

            ConvertSpecific(param, result);

            return result;
        }

        public override EmployeeResult ConvertSpecific(Data.Entity.Employee param, EmployeeResult result)
        {
            result.ContractId = param.Contract.Id;
            result.ContractName = param.Contract.Name;

            result.EmployeeStatusId = param.EmployeeStatus.Id;
            result.EmployeeStatusName = param.EmployeeStatus.Name;

            return result;
        }
    }
}
