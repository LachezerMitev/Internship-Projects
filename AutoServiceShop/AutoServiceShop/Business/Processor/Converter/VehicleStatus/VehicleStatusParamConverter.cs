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
<<<<<<< Updated upstream
        IVehicleStatusDao VehicleStatusDao { get; set; }
=======
>>>>>>> Stashed changes

        public override void ConvertSpecific(VehicleStatusParam param, Data.Entity.VehicleStatus entity) { }

        public override Data.Entity.VehicleStatus GetResult(VehicleStatusParam param)
        {
            Data.Entity.VehicleStatus entity = new Data.Entity.VehicleStatus
            {
                Id = param.Id,
                Code = param.Code
            };

            return entity;
        }
    }
}
