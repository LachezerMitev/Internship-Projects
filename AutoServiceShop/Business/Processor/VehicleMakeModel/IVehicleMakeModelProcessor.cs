using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.VehicleMakeModel
{
    interface IVehicleMakeModelProcessor
    {
        VehicleMakeModelResult Create(VehicleMakeModelParam param);
        List<VehicleMakeModelResult> Create(List<VehicleMakeModelParam> param);

        void Update(long id, VehicleMakeModelParam param);
        void Update(List<VehicleMakeModelParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        VehicleMakeModelResult Find(long id);
        List<VehicleMakeModelResult> Find();
    }
}
