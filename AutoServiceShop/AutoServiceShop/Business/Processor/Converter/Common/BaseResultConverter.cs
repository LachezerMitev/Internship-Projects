using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Common
{
    abstract class BaseResultConverter<Tin, Tout> : IBaseResultConverter<Tin, Tout>
        where Tin : class, new()
        where Tout : class, new()
    {
        public Tout ConverterStandart(Tin param, Tout result)
        {
            // Dictionary of key = param.Name | value = param.PropertyInFo
            Dictionary<string, PropertyInfo> paramPropsDict = param.GetType().GetProperties()
                .ToDictionary(x => x.Name, x => x);

            Dictionary<string, PropertyInfo> resultPropsDict = result.GetType().GetProperties()
                .ToDictionary(x => x.Name, x => x);

            ///////////////////////////////////////////////////////////////////////////////////

            // foreach going through all items in dictionary
            foreach (var paramItem in paramPropsDict)
            {
                // Tries to take any property from result that is named as the paramItem.key
                if (resultPropsDict.ContainsKey(paramItem.Key))
                {
                    // Set value in result
                    result.GetType().GetProperty(paramItem.Key).SetValue(result, paramItem.Value.GetValue(param));
                }
            }

            return result;
        }

        public abstract Tout ConvertSpecific(Tin param, Tout result);
    }
}
