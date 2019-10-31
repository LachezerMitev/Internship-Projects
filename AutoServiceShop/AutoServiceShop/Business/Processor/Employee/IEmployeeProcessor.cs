using AutoServiceShop.Business.Processor.Converter.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Employee
{
    interface IEmployeeProcessor
    {
        EmployeeResult Create(EmployeeParam param);
        List<EmployeeResult> Create(List<EmployeeParam> param);

        void Update(long id, EmployeeParam param);
        void Update(List<EmployeeParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        EmployeeResult Find(long id);
        List<EmployeeResult> Find();
    }
}
