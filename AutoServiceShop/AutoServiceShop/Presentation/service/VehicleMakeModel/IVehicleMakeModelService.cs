using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.VehicleMakeModel
{
    interface IVehicleMakeModelService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(VehicleMakeModelParam param);
        ApiResponse Create(List<VehicleMakeModelParam> param);

        ApiResponse Update(long id, VehicleMakeModelParam param);
        ApiResponse Update(List<VehicleMakeModelParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(VehicleMakeModelParam param);
        void ValidateParameters(List<VehicleMakeModelParam> param);
    }
}
