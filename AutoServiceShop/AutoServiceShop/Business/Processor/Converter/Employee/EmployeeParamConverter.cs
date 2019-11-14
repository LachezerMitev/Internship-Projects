using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Employee;
using AutoServiceShop.Dataaccess.Dao.EmployeeStatus;
using AutoServiceShop.Dataaccess.Dao.Contract;
using AutoServiceShop.Business.Processor.Converter.Common;

namespace AutoServiceShop.Business.Processor.Converter.Employee
{
    class EmployeeParamConverter : BaseParamConverter<EmployeeParam, Data.Entity.Employee>, IEmployeeParamConverter
    {
        IEmployeeDao EmployeeDao = new EmployeeDao();
        IEmployeeStatusDao EmployeeStatusDao = new EmployeeStatusDao();
        IContractDao ContractDao = new ContractDao();

        public Data.Entity.Employee Convert(EmployeeParam param, Data.Entity.Employee oldentity)
        {
            Data.Entity.Employee entity = null;

            if (oldentity != null)
            {
                if (param.Id == oldentity.Id && param.Code == oldentity.Code)
                    entity = oldentity;
                else
                    throw new Exception("You have changed either the ID or the description");
            }
            else
            {
                entity = new Data.Entity.Employee
                {
                    Code = param.Code,
                    Id = param.Id,
                };
            }

            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.Employee ConvertSpecific(EmployeeParam param, Data.Entity.Employee entity)
        {
            entity.EmployeeStatus = EmployeeStatusDao.Find(param.EmployeeStatusId);
            entity.Contract = ContractDao.Find(param.ContractId);

            return entity;
        }
    }
}
