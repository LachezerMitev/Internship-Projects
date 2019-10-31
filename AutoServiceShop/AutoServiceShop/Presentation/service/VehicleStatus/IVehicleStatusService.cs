using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.VehicleStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.VehicleStatus
{
    interface IVehicleStatusService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(VehicleStatusParam param);
        ApiResponse Create(List<VehicleStatusParam> param);

        ApiResponse Update(long id, VehicleStatusParam param);
        ApiResponse Update(List<VehicleStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(VehicleStatusParam param);
        void ValidateParameters(List<VehicleStatusParam> param);
    }
}
