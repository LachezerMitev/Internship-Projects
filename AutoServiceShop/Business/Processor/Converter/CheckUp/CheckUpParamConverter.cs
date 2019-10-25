using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.CheckUp;

namespace AutoServiceShop.Business.Processor.Converter.CheckUp
{
    class CheckUpParamConverter : ICheckUpParamConverter
    {
        ICheckUpDao CheckUpDao { get; set; }

        public Data.Entity.CheckUp Convert(CheckUpParam param)
        {
            Data.Entity.CheckUp result = new Data.Entity.CheckUp()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,

                CheckUpEnd = param.CheckUpEnd,
                CheckUpStart = param.CheckUpStart,
                CheckUpStatus = param.CheckUpStatus,
                Customer = param.Customer,
                Employee = param.Employee,
                IssueList = param.IssueList,
                PartList = param.PartList,
                Price = param.Price,
                Vehicle = param.Vehicle
            };

            return result;
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
                entity = new Data.Entity.CheckUp();
            }

            entity.Code = param.Code;
            entity.Id = param.Id;
            entity.Description = param.Description;
            entity.Name = param.Name;

            entity.CheckUpEnd = param.CheckUpEnd;
            entity.CheckUpStart = param.CheckUpStart;
            entity.CheckUpStatus = param.CheckUpStatus;
            entity.Customer = param.Customer;
            entity.Employee = param.Employee;
            entity.IssueList = param.IssueList;
            entity.PartList = param.PartList;
            entity.Price = param.Price;
            entity.Vehicle = param.Vehicle;

            return entity;
        }
    }
}
