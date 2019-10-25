using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Employee;

namespace AutoServiceShop.Business.Processor.Converter.Employee
{
    class EmployeeParamConverter : IEmployeeParamConverter
    {
        IEmployeeDao EmployeeDao { get; set; }

        public Data.Entity.Employee Convert(EmployeeParam param)
        {
            Data.Entity.Employee result = new Data.Entity.Employee()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,

                Contract = param.Contract,
                EmployeeStatus = param.EmployeeStatus
            };

            return result;
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
                entity = new Data.Entity.Employee();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;

            entity.EmployeeStatus = param.EmployeeStatus;
            entity.Contract = param.Contract;

            return entity;
        }
    }
}
