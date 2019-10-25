using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.EmployeeStatus;

namespace AutoServiceShop.Business.Processor.Converter.EmployeeStatus
{
    class EmployeeStatusParamConverter : IEmployeeStatusParamConverter
    {
        IEmployeeStatusDao EmployeeStatusDao { get; set; }

        public Data.Entity.EmployeeStatus Convert(EmployeeStatusParam param)
        {
            Data.Entity.EmployeeStatus result = new Data.Entity.EmployeeStatus()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name
            };

            return result;
        }

        public Data.Entity.EmployeeStatus Convert(EmployeeStatusParam param, Data.Entity.EmployeeStatus oldentity)
        {
            Data.Entity.EmployeeStatus entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.EmployeeStatus();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;

            return entity;
        }
    }
}
