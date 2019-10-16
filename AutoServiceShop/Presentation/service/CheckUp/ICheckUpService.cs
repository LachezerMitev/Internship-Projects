using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.CheckUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.CheckUp
{
    interface ICheckUpService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(CheckUpParam param);
        ApiResponse Create(List<CheckUpParam> param);

        ApiResponse Update(long id, CheckUpParam param);
        ApiResponse Update(List<CheckUpParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(CheckUpParam param);
        void ValidateParameters(List<CheckUpParam> param);
    }
}
