using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Vehicle;
using AutoServiceShop.Business.Processor.Vehicle;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Vehicle
{
    class VehicleService : IVehicleService
    {
        IVehicleProcessor VehicleProcessor { get; set; }

        public ApiResponse Create(VehicleParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<VehicleParam> param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ApiResponse DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse FindByPK(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListAll()
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(long id, VehicleParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<VehicleParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(VehicleParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<VehicleParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
