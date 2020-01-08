using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.CheckUp
{
    class CheckUpResultConverter : BaseResultConverter<Data.Entity.CheckUp, CheckUpResult>, ICheckUpResultConverter
    {
        public override void ConvertSpecific(Data.Entity.CheckUp param, CheckUpResult result)
        {
            result.VehicleId = param.Vehicle.Id;
            result.VehicleName = param.Vehicle.Name;
            result.CheckUpStatusId = param.CheckUpStatus.Id;
            result.CheckUpStatusName = param.CheckUpStatus.Name;
        }
    }
}
