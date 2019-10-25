using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Business.Processor.Converter.CheckUp
{
    class CheckUpResultConverter : ICheckUpResultConverter
    {
        public CheckUpResult Convert(Data.Entity.CheckUp param)
        {
            CheckUpResult result = new CheckUpResult()
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
    }
}
