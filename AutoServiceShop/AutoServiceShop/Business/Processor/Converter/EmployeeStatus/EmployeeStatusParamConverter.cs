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
        EmployeeStatusDao EmployeeStatusDao { get; set; }

        public Data.Entity.EmployeeStatus Convert(EmployeeStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
