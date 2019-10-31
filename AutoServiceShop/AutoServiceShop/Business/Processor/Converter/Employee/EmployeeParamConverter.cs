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
        IEmployeeDao EmployeeDao = new EmployeeDao();
        IEmployeeStatusDao EmployeeStatusDao = new EmployeeStatusDao();
        IContractDao ContractDao = new ContractDao();

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
            
            entity.EmployeeStatus = EmployeeStatusDao.Find(param.EmployeeStatusId);
            entity.Contract = ContractDao.Find(param.ContractId);

            return entity;
        }
    }
}
