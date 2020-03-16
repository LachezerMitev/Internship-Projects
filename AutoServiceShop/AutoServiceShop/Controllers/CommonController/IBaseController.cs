using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.CommonController
{
    interface IBaseController<TProcessor, TParamConverter, TResultConverter, TParam, TResult, TDao, TId, TEntity>
    {
        IActionResult Create(TParam param);

        IActionResult CreateWithList(List<TParam> param);
        
        IActionResult Delete(List<TId> idList);

        IActionResult DeleteById(TId id);

        IActionResult FindByPK(TId id);

        IActionResult FindByField(string field, string value);

        IActionResult ListAll();

        IActionResult Update(TId id, TParam param);

        IActionResult UpdateByList(List<TParam> param);
    }
}
