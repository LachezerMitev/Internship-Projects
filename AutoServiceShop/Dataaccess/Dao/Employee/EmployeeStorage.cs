using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Employee
{
    class EmployeeStorage
    {
        public static List<Data.Entity.Employee> EmployeeList = new List<Data.Entity.Employee>();
        public static Dictionary<long, Data.Entity.Employee> EmployeeDictionary = new Dictionary<long, Data.Entity.Employee>();

        static EmployeeStorage()
        {
            Data.Entity.Employee Employee1 = new Data.Entity.Employee
            {

            };

            Data.Entity.Employee Employee2 = new Data.Entity.Employee
            {

            };

            Data.Entity.Employee Employee3 = new Data.Entity.Employee
            {

            };
            Data.Entity.Employee Employee4 = new Data.Entity.Employee
            {

            };
            Data.Entity.Employee Employee5 = new Data.Entity.Employee
            {

            };
            Data.Entity.Employee Employee6 = new Data.Entity.Employee
            {

            };
            Data.Entity.Employee Employee7 = new Data.Entity.Employee
            {

            };
            Data.Entity.Employee Employee8 = new Data.Entity.Employee
            {

            };
            Data.Entity.Employee Employee9 = new Data.Entity.Employee
            {

            };
            Data.Entity.Employee Employee10 = new Data.Entity.Employee
            {

            };

            EmployeeList.Add(Employee1);
            EmployeeList.Add(Employee2);
            EmployeeList.Add(Employee3);
            EmployeeList.Add(Employee4);
            EmployeeList.Add(Employee5);
            EmployeeList.Add(Employee6);
            EmployeeList.Add(Employee7);
            EmployeeList.Add(Employee8);
            EmployeeList.Add(Employee9);
            EmployeeList.Add(Employee10);

            EmployeeDictionary.Add(Employee1.Id, Employee1);
            EmployeeDictionary.Add(Employee2.Id, Employee2);
            EmployeeDictionary.Add(Employee3.Id, Employee3);
            EmployeeDictionary.Add(Employee4.Id, Employee4);
            EmployeeDictionary.Add(Employee5.Id, Employee5);
            EmployeeDictionary.Add(Employee6.Id, Employee6);
            EmployeeDictionary.Add(Employee7.Id, Employee7);
            EmployeeDictionary.Add(Employee8.Id, Employee8);
            EmployeeDictionary.Add(Employee9.Id, Employee9);
            EmployeeDictionary.Add(Employee10.Id, Employee10);

        }
    }
}
