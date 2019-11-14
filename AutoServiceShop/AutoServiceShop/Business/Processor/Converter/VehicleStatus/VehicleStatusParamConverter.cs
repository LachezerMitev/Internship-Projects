using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;

namespace AutoServiceShop.Business.Processor.Converter.VehicleStatus
{
    class VehicleStatusParamConverter : BaseParamConverter<VehicleStatusParam, Data.Entity.VehicleStatus>, IVehicleStatusParamConverter
    {
        IVehicleStatusDao VehicleStatusDao = new VehicleStatusDao();

        public Data.Entity.VehicleStatus Convert(VehicleStatusParam param, Data.Entity.VehicleStatus oldentity)
        {
            Data.Entity.VehicleStatus entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.VehicleStatus
                {
                    Code = param.Code,
                    Id = param.Id
                };
            }

            ConverterStandart(param, entity);

            return entity;
        }

        public override Data.Entity.VehicleStatus ConvertSpecific(VehicleStatusParam param, Data.Entity.VehicleStatus entity)
        {
            throw new NotImplementedException();
        }
    }
}
