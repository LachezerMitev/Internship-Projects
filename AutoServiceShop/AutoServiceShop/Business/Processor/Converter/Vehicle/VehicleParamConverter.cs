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
        private IVehicleStatusDao _vehicleStatusDao;
        public IVehicleStatusDao VehicleStatusDao
        {

            set { _vehicleStatusDao = value; }

            get
            {
                if (_vehicleStatusDao == null)
                {
                    _vehicleStatusDao = new VehicleStatusDao();
                    return _vehicleStatusDao;
                }
                else
                {
                    return _vehicleStatusDao;
                }
            }
        }

        private ICustomerDao _customerDao;
        public ICustomerDao CustomerDao
        {

            set { _customerDao = value; }

            get
            {
                if (_customerDao == null)
                {
                    _customerDao = new CustomerDao();
                    return _customerDao;
                }
                else
                {
                    return _customerDao;
                }
            }
        }

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
<<<<<<< Updated upstream
            
            entity.Owner = CustomerDao.Find(param.OwnerId);
            entity.Mileage = param.Mileage;
            entity.DateOfProduction = param.DateOfProduction;
            entity.VehicleStatus = VehicleStatusDao.Find(param.VehicleStatusId);
=======

            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.Vehicle ConvertSpecific(VehicleParam param, Data.Entity.Vehicle entity)
        {
            entity.Owner = _customerDao.Find(param.OwnerId);
            entity.VehicleStatus = _vehicleStatusDao.Find(param.VehicleStatusId);
>>>>>>> Stashed changes

            return entity;
        }
    }
}
