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

        public override void ConvertSpecific(VehicleStatusParam param, Data.Entity.VehicleStatus entity) { }

        public override Data.Entity.VehicleStatus GetResult(VehicleStatusParam param)
        {
<<<<<<< Updated upstream
            Data.Entity.VehicleStatus entity = null;
=======
            Data.Entity.VehicleStatus entity = new Data.Entity.VehicleStatus
            {
                Id = param.Id,
                Code = param.Code,
                Active = param.Active
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
