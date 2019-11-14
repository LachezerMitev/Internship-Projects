using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;
using AutoServiceShop.Dataaccess.Dao.Customer;
using AutoServiceShop.Business.Processor.Converter.Common;

namespace AutoServiceShop.Business.Processor.Converter.Vehicle
{
    class VehicleParamConverter : BaseParamConverter<VehicleParam, Data.Entity.Vehicle>, IVehicleParamConverter
    {
        IVehicleDao VehicleDao = new VehicleDao();
        IVehicleStatusDao VehicleStatusDao = new VehicleStatusDao();
        ICustomerDao CustomerDao = new CustomerDao();

        public Data.Entity.Vehicle Convert(VehicleParam param, Data.Entity.Vehicle oldentity)
        {
            Data.Entity.Vehicle entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.Vehicle
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.Vehicle ConvertSpecific(VehicleParam param, Data.Entity.Vehicle entity)
        {
            entity.Owner = CustomerDao.Find(param.OwnerId);
            entity.VehicleStatus = VehicleStatusDao.Find(param.VehicleStatusId);

            return entity;
        }
    }
}
