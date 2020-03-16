using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Common
{
    public interface IBaseResultConverter<TEntity, TResult>
    {
        TResult ConverterStandart(TEntity param, TResult result);

        void ConvertSpecific(TEntity param, TResult result);

        TResult Convert(TEntity entity);
    }
}
