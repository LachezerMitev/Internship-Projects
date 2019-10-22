using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.VehicleStatus;
using AutoServiceShop.Business.Processor.VehicleStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.VehicleStatus
{
    class VehicleStatusService : IVehicleStatusService
    {
        IVehicleStatusProcessor VehicleStatusProcessor { get; set; }

        public ApiResponse Create(VehicleStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<VehicleStatusParam> param)
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

        public ApiResponse Update(long id, VehicleStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<VehicleStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(VehicleStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<VehicleStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
