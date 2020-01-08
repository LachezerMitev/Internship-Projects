using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;
using AutoServiceShop.Business.Processor.Converter.Common;

namespace AutoServiceShop.Business.Processor.Converter.Vehicle
{
    class VehicleParamConverter : BaseParamConverter<VehicleParam, Data.Entity.Vehicle>, IVehicleParamConverter
    {
<<<<<<< Updated upstream
        IVehicleDao VehicleDao = new VehicleDao();
        IVehicleStatusDao VehicleStatusDao = new VehicleStatusDao();
        ICustomerDao CustomerDao = new CustomerDao();
=======
        private IVehicleStatusDao _vehicleStatusDao;
        public IVehicleStatusDao VehicleStatusDao
        {

            set { _vehicleStatusDao = value; }

            get
            {
                if (_vehicleStatusDao == null)
                {
                    return _vehicleStatusDao;
                }
                else
                {
                    return _vehicleStatusDao;
                }
            }
        }

        public override void ConvertSpecific(VehicleParam param, Data.Entity.Vehicle entity)
        {
            entity.VehicleStatus = _vehicleStatusDao.Find(param.VehicleStatusId);
        }
>>>>>>> Stashed changes

        public override Data.Entity.Vehicle GetResult(VehicleParam param)
        {
            Data.Entity.Vehicle entity = new Data.Entity.Vehicle
            {
<<<<<<< Updated upstream
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
                Id = param.Id,
                Code = param.Code
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
