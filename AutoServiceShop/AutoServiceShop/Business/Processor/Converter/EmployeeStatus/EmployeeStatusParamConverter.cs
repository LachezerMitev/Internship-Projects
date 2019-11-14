using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.EmployeeStatus;

namespace AutoServiceShop.Business.Processor.Converter.EmployeeStatus
{
    class EmployeeStatusParamConverter : BaseParamConverter<EmployeeStatusParam, Data.Entity.EmployeeStatus>, IEmployeeStatusParamConverter
    {
        IEmployeeStatusDao EmployeeStatusDao = new EmployeeStatusDao();

        public Data.Entity.EmployeeStatus Convert(EmployeeStatusParam param, Data.Entity.EmployeeStatus oldentity)
        {
            Data.Entity.EmployeeStatus entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.EmployeeStatus
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            return entity;
        }

        public override Data.Entity.EmployeeStatus ConvertSpecific(EmployeeStatusParam param, Data.Entity.EmployeeStatus entity)
        {
            throw new NotImplementedException();
        }
    }
}
