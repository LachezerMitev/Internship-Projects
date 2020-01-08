using AutoServiceShop.Business.Processor.Converter.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.VehicleStatus
{
    public interface IVehicleStatusParamConverter : IBaseParamConverter<VehicleStatusParam, Data.Entity.VehicleStatus>
    {
    }
}
