using AutoServiceShop.Business.Processor.Converter.VehicleStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.VehicleStatus
{
    interface IVehicleStatusProcessor
    {
        VehicleStatusResult Create(VehicleStatusParam param);
        List<VehicleStatusResult> Create(List<VehicleStatusParam> param);

        void Update(long id, VehicleStatusParam param);
        void Update(List<VehicleStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        VehicleStatusResult Find(long id);
        List<VehicleStatusResult> Find();
    }
}
