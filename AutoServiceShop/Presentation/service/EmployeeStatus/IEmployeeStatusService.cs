using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.EmployeeStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.EmployeeStatus
{
    interface IEmployeeStatusService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(EmployeeStatusParam param);
        ApiResponse Create(List<EmployeeStatusParam> param);

        ApiResponse Update(long id, EmployeeStatusParam param);
        ApiResponse Update(List<EmployeeStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(EmployeeStatusParam param);
        void ValidateParameters(List<EmployeeStatusParam> param);
    }
}
