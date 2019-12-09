using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Employee;
using AutoServiceShop.Dataaccess.Dao.EmployeeStatus;
using AutoServiceShop.Dataaccess.Dao.Contract;

namespace AutoServiceShop.Business.Processor.Converter.Employee
{
    class EmployeeParamConverter : IEmployeeParamConverter
    {
        private IEmployeeStatusDao _employeeStatusDao;
        public IEmployeeStatusDao EmployeeStatusDao
        {

            set { _employeeStatusDao = value; }

            get
            {
                if (_employeeStatusDao == null)
                {
                    _employeeStatusDao = new EmployeeStatusDao();
                    return _employeeStatusDao;
                }
                else
                {
                    return _employeeStatusDao;
                }
            }
        }

        private IContractDao _contractDao;
        public IContractDao ContractDao
        {

            set { _contractDao = value; }

            get
            {
                if (_contractDao == null)
                {
                    _contractDao = new ContractDao();
                    return _contractDao;
                }
                else
                {
                    return _contractDao;
                }
            }
        }

        public Data.Entity.Employee Convert(EmployeeParam param, Data.Entity.Employee oldentity)
        {
            Data.Entity.Employee entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.Employee
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }
<<<<<<< Updated upstream
            
            entity.EmployeeStatus = EmployeeStatusDao.Find(param.EmployeeStatusId);
            entity.Contract = ContractDao.Find(param.ContractId);
=======

            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.Employee ConvertSpecific(EmployeeParam param, Data.Entity.Employee entity)
        {
            entity.EmployeeStatus = _employeeStatusDao.Find(param.EmployeeStatusId);
            entity.Contract = _contractDao.Find(param.ContractId);
>>>>>>> Stashed changes

            return entity;
        }
    }
}
