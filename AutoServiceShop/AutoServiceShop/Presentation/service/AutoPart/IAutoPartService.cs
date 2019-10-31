using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.AutoPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.AutoPart
{
    interface IAutoPartService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(AutoPartParam param);
        ApiResponse Create(List<AutoPartParam> param);

        ApiResponse Update(long id, AutoPartParam param);
        ApiResponse Update(List<AutoPartParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(AutoPartParam param);
        void ValidateParameters(List<AutoPartParam> param);
    }
}
