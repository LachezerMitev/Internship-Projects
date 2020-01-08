using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Common
{
    public interface IBaseProcessor<TParamConverter, TResultConverter, TParam, TResult, TDao, TId, TEntity>
    {
        TResult Create(TParam param);
        List<TResult> Create(List<TParam> param);

        void Update(TId id, TParam param);
        void Update(List<TParam> param);

        void Delete(TId id);
        void Delete(List<TId> idList);

        TResult Find(TId id);
        List<TResult> Find();
        List<TResult> Find(string field, string value);
    }
}
