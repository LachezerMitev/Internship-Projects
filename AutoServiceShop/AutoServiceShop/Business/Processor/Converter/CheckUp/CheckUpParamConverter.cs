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
        private ICheckUpDao _checkUpDao;
        public ICheckUpDao CheckUpDao
        {

            set { _checkUpDao = value; }

            get
            {
                if (_checkUpDao == null)
                {
                    _checkUpDao = new CheckUpDao();
                    return _checkUpDao;
                }
                else
                {
                    return _checkUpDao;
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

        private IEmployeeDao _employeeDao;
        public IEmployeeDao EmployeeDao
        {

            set { _employeeDao = value; }

            get
            {
                if (_employeeDao == null)
                {
                    _employeeDao = new EmployeeDao();
                    return _employeeDao;
                }
                else
                {
                    return _employeeDao;
                }
            }
        }

        private IVehicleDao _vehicleDao;
        public IVehicleDao VehicleDao
        {

            set { _vehicleDao = value; }

            get
            {
                if (_vehicleDao == null)
                {
                    _vehicleDao = new VehicleDao();
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
                    _checkUpStatusDao = new CheckUpStatusDao();
                    return _checkUpStatusDao;
                }
                else
                {
                    return _checkUpStatusDao;
                }
            }
        }

        public Data.Entity.CheckUp Convert(CheckUpParam param, Data.Entity.CheckUp oldentity)
        {
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

<<<<<<< Updated upstream
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
            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.CheckUp ConvertSpecific(CheckUpParam param, Data.Entity.CheckUp entity)
        {
            entity.CheckUpStatus = _checkUpStatusDao.Find(param.CheckUpStatusId);
            entity.Customer = _customerDao.Find(param.CustomerId);
            entity.Employee = _employeeDao.Find(param.EmployeeId);
            entity.Vehicle = _vehicleDao.Find(param.VehicleId);
>>>>>>> Stashed changes

            return entity;
        }
    }
}
