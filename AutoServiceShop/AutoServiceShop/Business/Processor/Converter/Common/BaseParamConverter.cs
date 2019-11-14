using AutoServiceShop.Business.Processor.Converter.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Common
{
    abstract class BaseParamConverter<Tin, Tout> : IBaseParamConverter<Tin, Tout>
        where Tin : class, new()
        where Tout: class, new()
    {
        public Tout ConverterStandart(Tin param, Tout entity)
        {
            //// Dictionary from param where key = param.Name | value = param.Property | Ignores pre-defined properties with attribute
            //Dictionary<string, PropertyInfo> paramPropsDict = param.GetType().GetProperties()
            //    .Where(p => !Attribute.IsDefined(p, typeof(ParamProperty)))
            //    .ToDictionary(x => x.Name, x => x);

            Dictionary<string, PropertyInfo> paramPropsDict = param.GetType().GetProperties()
                .Where(p => IsIgnored(p) == false)
                .ToDictionary(x => x.Name, x => x);


            Dictionary<string, PropertyInfo> entityPropsDict = entity.GetType().GetProperties()
                .Where(p => !Attribute.IsDefined(p, typeof(ParamProperty)))
                .ToDictionary(x => x.Name, x => x);

            // Cycles all in Dictionary
            foreach (var paramItem in paramPropsDict)
            {
                // Checks if the names from the entity are the same with the selected param
                if (entityPropsDict.ContainsKey(paramItem.Key))
                {
                    // Assigns value to entityby getting the property with paramItem.Key
                    entity.GetType().GetProperty(paramItem.Key).SetValue(entity, paramItem.Value.GetValue(param));
                }
            }

            return entity;
        }

        public abstract Tout ConvertSpecific(Tin param, Tout entity);

        public bool IsIgnored(PropertyInfo t)
        {
            ParamProperty ignoreProp = (ParamProperty)Attribute.GetCustomAttribute(t, typeof(ParamProperty));

            if (ignoreProp != null)
            {
                if (ignoreProp.Ignore == true)
                    return true;
                else
                    return false;
            }
            return false;
        }
    }

    
}
