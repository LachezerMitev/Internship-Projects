using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.CheckUp;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.Common;

namespace AutoServiceShop.Business.Processor.Converter.CheckUp
{
    class CheckUpParamConverter : BaseParamConverter<CheckUpParam, Data.Entity.CheckUp>, ICheckUpParamConverter
    {
<<<<<<< Updated upstream
        ICheckUpDao CheckUpDao = new CheckUpDao();
        ICustomerDao CustomerDao = new CustomerDao();
        IEmployeeDao EmployeeDao = new EmployeeDao();
        IVehicleDao VehicleDao = new VehicleDao();
        ICheckUpStatusDao CheckUpStatusDao = new CheckUpStatusDao();
=======

        private readonly IVehicleDao _vehicleDao;

        private readonly ICheckUpStatusDao _checkUpStatusDao;
>>>>>>> Stashed changes

        public CheckUpParamConverter(IVehicleDao vehicleDao, ICheckUpStatusDao checkUpStatusDao)
        {
<<<<<<< Updated upstream
            Data.Entity.CheckUp entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.CheckUp
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

            entity.CheckUpEnd = param.CheckUpEnd;
            entity.CheckUpStart = param.CheckUpStart;
            entity.CheckUpStatus = CheckUpStatusDao.Find(param.CheckUpStatusId);
            entity.Customer = CustomerDao.Find(param.CustomerId);
            entity.Employee = EmployeeDao.Find(param.EmployeeId);
            entity.IssueList = param.IssueList;
            entity.PartList = param.PartList;
            entity.Price = param.Price;
            entity.Vehicle = VehicleDao.Find(param.VehicleId);
=======
            _vehicleDao = vehicleDao;
            _checkUpStatusDao = checkUpStatusDao;
        }

        public override void ConvertSpecific(CheckUpParam param, Data.Entity.CheckUp entity)
        {
            entity.CheckUpStatus = _checkUpStatusDao.Find(param.CheckUpStatusId);
            entity.Vehicle = _vehicleDao.Find(param.VehicleId);
        }

        public override Data.Entity.CheckUp GetResult(CheckUpParam param)
        {
            Data.Entity.CheckUp entity = new Data.Entity.CheckUp
            {
                Code = param.Code,
                Id = param.Id,
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
