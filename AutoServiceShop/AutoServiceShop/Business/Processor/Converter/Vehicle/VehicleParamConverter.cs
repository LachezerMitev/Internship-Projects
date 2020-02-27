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
<<<<<<< Updated upstream
        IVehicleDao VehicleDao = new VehicleDao();
        IVehicleStatusDao VehicleStatusDao = new VehicleStatusDao();
        ICustomerDao CustomerDao = new CustomerDao();
=======
        private readonly IVehicleStatusDao _vehicleStatusDao;
>>>>>>> Stashed changes

        public Data.Entity.Vehicle Convert(VehicleParam param, Data.Entity.Vehicle oldentity)
        {
<<<<<<< Updated upstream
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
=======
            _vehicleStatusDao = vehicleStatusDao;
        }

        public override void ConvertSpecific(VehicleParam param, Data.Entity.Vehicle entity)
        {
            entity.VehicleStatus = _vehicleStatusDao.Find(param.VehicleStatusId);
        }

        public override Data.Entity.Vehicle GetResult(VehicleParam param)
        {
            Data.Entity.Vehicle entity = new Data.Entity.Vehicle
            {
                Id = param.Id,
                Code = param.Code
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
