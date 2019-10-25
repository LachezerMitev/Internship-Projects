using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.EmployeeStatus
{
    class EmployeeStatusResultConverter : IEmployeeStatusResultConverter
    {
        public EmployeeStatusResult Convert(Data.Entity.EmployeeStatus param)
        {
            EmployeeStatusResult result = new EmployeeStatusResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }
    }
}
