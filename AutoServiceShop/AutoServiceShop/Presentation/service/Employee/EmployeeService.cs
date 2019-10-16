using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Employee;
using AutoServiceShop.Business.Processor.Employee;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Employee
{
    class EmployeeService : IEmployeeService
    {
        EmployeeProcessor EmployeeProcessor { get; set; }

        public ApiResponse Create(EmployeeParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<EmployeeParam> param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ApiResponse DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse FindByPK(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListAll()
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(long id, EmployeeParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<EmployeeParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(EmployeeParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<EmployeeParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
