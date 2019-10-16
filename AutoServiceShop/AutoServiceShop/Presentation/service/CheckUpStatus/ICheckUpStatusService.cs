using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.CheckUpStatus
{
    interface ICheckUpStatusService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(CheckUpStatusParam param);
        ApiResponse Create(List<CheckUpStatusParam> param);

        ApiResponse Update(long id, CheckUpStatusParam param);
        ApiResponse Update(List<CheckUpStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(CheckUpStatusParam param);
        void ValidateParameters(List<CheckUpStatusParam> param);
    }
}
