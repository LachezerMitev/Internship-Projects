using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.Vehicle
{
    interface IVehicleService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(VehicleParam param);
        ApiResponse Create(List<VehicleParam> param);

        ApiResponse Update(long id, VehicleParam param);
        ApiResponse Update(List<VehicleParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(VehicleParam param);
        void ValidateParameters(List<VehicleParam> param);
    }
}
