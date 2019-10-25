using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.Employee
{
    interface IEmployeeService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(EmployeeParam param);
        ApiResponse Create(List<EmployeeParam> param);

        ApiResponse Update(long id, EmployeeParam param);
        ApiResponse Update(List<EmployeeParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(EmployeeParam param);
        void ValidateParameters(List<EmployeeParam> param);
    }
}
