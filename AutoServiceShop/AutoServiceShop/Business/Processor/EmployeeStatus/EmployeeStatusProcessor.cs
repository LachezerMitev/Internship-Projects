using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.EmployeeStatus;
using AutoServiceShop.Business.Processor.Converter.EmployeeStatus;

namespace AutoServiceShop.Business.Processor.EmployeeStatus
{
    class EmployeeStatusProcessor : IEmployeeStatusProcessor
    {
        EmployeeStatusDao EmployeeStatusDao { get; set; }

        EmployeeStatusParamConverter EmployeeStatusParamConverter { get; set; }
        EmployeeStatusResultConverter EmployeeStatusResultConverter { get; set; }

        public EmployeeStatusResult Create(EmployeeStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeStatusResult> Create(List<EmployeeStatusParam> param)
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

        public EmployeeStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, EmployeeStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<EmployeeStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
