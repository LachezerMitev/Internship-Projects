using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.Common
{
    public interface IBaseParamConverter<TParam, TEntity>
    {
        TEntity ConverterStandart(TParam param, TEntity entity);

        void ConvertSpecific(TParam param, TEntity entity);

        TEntity Convert(TParam param, TEntity entity);
    }
}
