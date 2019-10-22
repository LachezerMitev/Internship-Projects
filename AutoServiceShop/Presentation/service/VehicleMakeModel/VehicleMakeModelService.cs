using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;
using AutoServiceShop.Business.Processor.VehicleMakeModel;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.VehicleMakeModel
{
    class VehicleMakeModelService : IVehicleMakeModelService
    {
        IVehicleMakeModelProcessor VehicleMakeModelProcessor { get; set; }

        public ApiResponse Create(VehicleMakeModelParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<VehicleMakeModelParam> param)
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

        public ApiResponse Update(long id, VehicleMakeModelParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<VehicleMakeModelParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(VehicleMakeModelParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<VehicleMakeModelParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
