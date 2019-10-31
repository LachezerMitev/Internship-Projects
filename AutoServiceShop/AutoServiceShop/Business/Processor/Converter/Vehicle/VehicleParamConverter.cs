using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;
using AutoServiceShop.Dataaccess.Dao.Customer;

namespace AutoServiceShop.Business.Processor.Converter.Vehicle
{
    class VehicleParamConverter : IVehicleParamConverter
    {
        IVehicleDao VehicleDao = new VehicleDao();
        IVehicleStatusDao VehicleStatusDao = new VehicleStatusDao();
        ICustomerDao CustomerDao = new CustomerDao();

        public Data.Entity.Vehicle Convert(VehicleParam param, Data.Entity.Vehicle oldentity)
        {
            Data.Entity.Vehicle entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.Vehicle
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }
            
            entity.Owner = CustomerDao.Find(param.OwnerId);
            entity.Mileage = param.Mileage;
            entity.DateOfProduction = param.DateOfProduction;
            entity.VehicleStatus = VehicleStatusDao.Find(param.VehicleStatusId);

            return entity;
        }
    }
}
