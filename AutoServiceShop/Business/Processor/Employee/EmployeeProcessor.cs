using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Employee;
using AutoServiceShop.Business.Processor.Converter.Employee;

namespace AutoServiceShop.Business.Processor.Employee
{
    class EmployeeProcessor : IEmployeeProcessor
    {
        IEmployeeDao EmployeeDao { get; set; }

        IEmployeeParamConverter EmployeeParamConverter { get; set; }
        IEmployeeResultConverter EmployeeResultConverter { get; set; }

        public EmployeeResult Create(EmployeeParam param)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeResult> Create(List<EmployeeParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public EmployeeResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, EmployeeParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<EmployeeParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
