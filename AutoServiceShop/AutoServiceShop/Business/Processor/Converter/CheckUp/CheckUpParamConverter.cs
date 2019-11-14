using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.CheckUp;
using AutoServiceShop.Dataaccess.Dao.Customer;
using AutoServiceShop.Dataaccess.Dao.Employee;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.Common;

namespace AutoServiceShop.Business.Processor.Converter.CheckUp
{
    class CheckUpParamConverter : BaseParamConverter<CheckUpParam, Data.Entity.CheckUp>, ICheckUpParamConverter
    {
        ICheckUpDao CheckUpDao = new CheckUpDao();
        ICustomerDao CustomerDao = new CustomerDao();
        IEmployeeDao EmployeeDao = new EmployeeDao();
        IVehicleDao VehicleDao = new VehicleDao();
        ICheckUpStatusDao CheckUpStatusDao = new CheckUpStatusDao();

        public Data.Entity.CheckUp Convert(CheckUpParam param, Data.Entity.CheckUp oldentity)
        {
            Data.Entity.CheckUp entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                {
                    entity = oldentity;
                }
                else
                {
                    throw new Exception("You have changed either the ID or the description");
                }
            }
            else
            {
                entity = new Data.Entity.CheckUp
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.CheckUp ConvertSpecific(CheckUpParam param, Data.Entity.CheckUp entity)
        {
            entity.CheckUpStatus = CheckUpStatusDao.Find(param.CheckUpStatusId);
            entity.Customer = CustomerDao.Find(param.CustomerId);
            entity.Employee = EmployeeDao.Find(param.EmployeeId);
            entity.Vehicle = VehicleDao.Find(param.VehicleId);

            return entity;
        }
    }
}
