using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.Make;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.Make
{
    interface IMakeService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(MakeParam param);
        ApiResponse Create(List<MakeParam> param);

        ApiResponse Update(long id, MakeParam param);
        ApiResponse Update(List<MakeParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(MakeParam param);
        void ValidateParameters(List<MakeParam> param);
    }
}
