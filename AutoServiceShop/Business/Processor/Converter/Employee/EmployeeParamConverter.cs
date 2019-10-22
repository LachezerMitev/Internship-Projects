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
            throw new NotImplementedException();
        }
    }
}
