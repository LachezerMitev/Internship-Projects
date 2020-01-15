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


namespace AutoServiceShop.Business.Processor.Converter.CheckUp
{
    class CheckUpParamConverter : ICheckUpParamConverter
    {
<<<<<<< Updated upstream
        ICheckUpDao CheckUpDao = new CheckUpDao();
        ICustomerDao CustomerDao = new CustomerDao();
        IEmployeeDao EmployeeDao = new EmployeeDao();
        IVehicleDao VehicleDao = new VehicleDao();
        ICheckUpStatusDao CheckUpStatusDao = new CheckUpStatusDao();
=======
        private ICheckUpDao _checkUpDao;
        public ICheckUpDao CheckUpDao
        {

            set { _checkUpDao = value; }

            get
            {
                if (_checkUpDao == null)
                {
                    return _checkUpDao;
                }
                else
                {
                    return _checkUpDao;
                }
            }
        }
>>>>>>> Stashed changes

        public Data.Entity.CheckUp Convert(CheckUpParam param, Data.Entity.CheckUp oldentity)
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

            set { _vehicleDao = value; }

            get
            {
                if (_vehicleDao == null)
                {
                    return _vehicleDao;
                }
                else
                {
                    return _vehicleDao;
                }
            }
        }

        private ICheckUpStatusDao _checkUpStatusDao;
        public ICheckUpStatusDao CheckUpStatusDao
        {

            set { _checkUpStatusDao = value; }

            get
            {
                if (_checkUpStatusDao == null)
                {
                    return _checkUpStatusDao;
                }
                else
                {
                    return _checkUpStatusDao;
                }
            }
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
