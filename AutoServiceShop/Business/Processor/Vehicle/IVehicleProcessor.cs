using AutoServiceShop.Business.Processor.Converter.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Vehicle
{
    interface IVehicleProcessor
    {
        VehicleResult Create(VehicleParam param);
        List<VehicleResult> Create(List<VehicleParam> param);

        void Update(long id, VehicleParam param);
        void Update(List<VehicleParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        VehicleResult Find(long id);
        List<VehicleResult> Find();
    }
}
