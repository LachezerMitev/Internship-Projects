using AutoServiceShop.Business.Processor.Converter.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Vehicle
{
    public interface IVehicleParamConverter : IBaseParamConverter<VehicleParam, Data.Entity.Vehicle>
    {
    }
}
