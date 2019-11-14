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
        public CheckUpResult Convert(Data.Entity.CheckUp param)
        {
            CheckUpResult result = new CheckUpResult();

            ConverterStandart(param, result);

            ConvertSpecific(param, result);

            return result;
        }

        public override CheckUpResult ConvertSpecific(Data.Entity.CheckUp param, CheckUpResult result)
        {
            result.VehicleId = param.Vehicle.Id;
            result.VehicleName = param.Vehicle.Name;
            result.CheckUpStatusId = param.CheckUpStatus.Id;
            result.CheckUpStatusName = param.CheckUpStatus.Name;
            result.CustomerId = param.Customer.Id;
            result.CustomerName = param.Customer.Name;
            result.EmployeeId = param.Employee.Id;
            result.EmployeeName = param.Employee.Name;

            return result;
        }
    }
}
