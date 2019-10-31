using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Employee
{
    class EmployeeResultConverter : IEmployeeResultConverter
    {
        public EmployeeResult Convert(Data.Entity.Employee param)
        {
            EmployeeResult result = new EmployeeResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,

                ContractId = param.Contract.Id,
                ContractName = param.Contract.Name,

                EmployeeStatusId = param.EmployeeStatus.Id,
                EmployeeStatusName = param.EmployeeStatus.Name
            };

            return result;
        }
    }
}
