using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.CheckUp
{
    class CheckUpResultConverter : ICheckUpResultConverter
    {
        public CheckUpResult Convert(Data.Entity.CheckUp param)
        {
<<<<<<< Updated upstream
            CheckUpResult result = new CheckUpResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,

                CheckUpEnd = param.CheckUpEnd,
                CheckUpStart = param.CheckUpStart,
                CustomerId = param.Customer.Id,
                CustomerName = param.Customer.Name,
                EmployeeId = param.Employee.Id,
                EmployeeName = param.Employee.Name,
                IssueList = param.IssueList,
                PartList = param.PartList,
                Price = param.Price,
                VehicleId = param.Vehicle.Id,
                VehicleName = param.Vehicle.Name,
                CheckUpStatusId = param.CheckUpStatus.Id,
                CheckUpStatusName = param.CheckUpStatus.Name
            };

            return result;
=======
            if (param.Vehicle == null || param.CheckUpStatus == null || param.Customer == null)
                throw new Exception("Some or all items in the entity taht are crucial were not found");

            result.VehicleId = param.Vehicle.Id;
            result.VehicleName = param.Vehicle.Name;
            result.CheckUpStatusId = param.CheckUpStatus.Id;
            result.CheckUpStatusName = param.CheckUpStatus.Name;
            result.CustomerId = param.Customer.Id;
            result.CustomerName = param.Customer.Name;
>>>>>>> Stashed changes
        }
    }
}
