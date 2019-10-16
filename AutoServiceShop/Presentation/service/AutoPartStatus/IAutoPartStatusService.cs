using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.AutoPartStatus
{
    interface IAutoPartStatusService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(AutoPartStatusParam param);
        ApiResponse Create(List<AutoPartStatusParam> param);

        ApiResponse Update(long id, AutoPartStatusParam param);
        ApiResponse Update(List<AutoPartStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(AutoPartStatusParam param);
        void ValidateParameters(List<AutoPartStatusParam> param);
    }
}
