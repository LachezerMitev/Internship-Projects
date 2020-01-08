using AutoServiceShop.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.Common
{
    public interface IBaseService<TProcessor, TParamConverter, TResultConverter, TParam, TResult, TDao, TId, TEntity>
    {
        ApiResponse Create(TParam param);

        ApiResponse Create(List<TParam> param);

        ApiResponse Delete(List<TId> idList);

        ApiResponse DeleteById(TId id);

        ApiResponse FindByPK(TId id);

        ApiResponse FindByField(string field, string value);

        ApiResponse ListAll();

        ApiResponse Update(TId id, TParam param);

        ApiResponse Update(List<TParam> param);

        void ValidateParameters(TParam param);

        void ValidateParameters(List<TParam> param);
    }
}
