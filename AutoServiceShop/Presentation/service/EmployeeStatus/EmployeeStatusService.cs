using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.EmployeeStatus;
using AutoServiceShop.Business.Processor.EmployeeStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.EmployeeStatus
{
    class EmployeeStatusService : IEmployeeStatusService
    {
        EmployeeStatusProcessor EmployeeStatusProcessor { get; set; }

        public ApiResponse Create(EmployeeStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<EmployeeStatusParam> param)
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

        public ApiResponse Update(long id, EmployeeStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<EmployeeStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(EmployeeStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<EmployeeStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
