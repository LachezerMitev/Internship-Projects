using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.Model
{
    interface IModelService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(ModelParam param);
        ApiResponse Create(List<ModelParam> param);

        ApiResponse Update(long id, ModelParam param);
        ApiResponse Update(List<ModelParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(ModelParam param);
        void ValidateParameters(List<ModelParam> param);
    }
}
