using AutoServiceShop.Business.Processor.Converter.EmployeeStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.EmployeeStatus
{
    interface IEmployeeStatusProcessor
    {
        EmployeeStatusResult Create(EmployeeStatusParam param);
        List<EmployeeStatusResult> Create(List<EmployeeStatusParam> param);

        void Update(long id, EmployeeStatusParam param);
        void Update(List<EmployeeStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        EmployeeStatusResult Find(long id);
        List<EmployeeStatusResult> Find();
    }
}
