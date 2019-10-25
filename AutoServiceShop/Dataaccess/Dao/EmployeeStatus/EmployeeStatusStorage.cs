using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.EmployeeStatus
{
    class EmployeeStatusStorage
    {
        public static List<Data.Entity.EmployeeStatus> EmployeeStatusList = new List<Data.Entity.EmployeeStatus>();
        public static Dictionary<long, Data.Entity.EmployeeStatus> EmployeeStatusDictionary = new Dictionary<long, Data.Entity.EmployeeStatus>();

        static EmployeeStatusStorage()
        {
            Data.Entity.EmployeeStatus EmployeeStatus1 = new Data.Entity.EmployeeStatus
            {

            };

            Data.Entity.EmployeeStatus EmployeeStatus2 = new Data.Entity.EmployeeStatus
            {

            };

            Data.Entity.EmployeeStatus EmployeeStatus3 = new Data.Entity.EmployeeStatus
            {

            };
            Data.Entity.EmployeeStatus EmployeeStatus4 = new Data.Entity.EmployeeStatus
            {

            };
            Data.Entity.EmployeeStatus EmployeeStatus5 = new Data.Entity.EmployeeStatus
            {

            };
            Data.Entity.EmployeeStatus EmployeeStatus6 = new Data.Entity.EmployeeStatus
            {

            };
            Data.Entity.EmployeeStatus EmployeeStatus7 = new Data.Entity.EmployeeStatus
            {

            };
            Data.Entity.EmployeeStatus EmployeeStatus8 = new Data.Entity.EmployeeStatus
            {

            };
            Data.Entity.EmployeeStatus EmployeeStatus9 = new Data.Entity.EmployeeStatus
            {

            };
            Data.Entity.EmployeeStatus EmployeeStatus10 = new Data.Entity.EmployeeStatus
            {

            };

            EmployeeStatusList.Add(EmployeeStatus1);
            EmployeeStatusList.Add(EmployeeStatus2);
            EmployeeStatusList.Add(EmployeeStatus3);
            EmployeeStatusList.Add(EmployeeStatus4);
            EmployeeStatusList.Add(EmployeeStatus5);
            EmployeeStatusList.Add(EmployeeStatus6);
            EmployeeStatusList.Add(EmployeeStatus7);
            EmployeeStatusList.Add(EmployeeStatus8);
            EmployeeStatusList.Add(EmployeeStatus9);
            EmployeeStatusList.Add(EmployeeStatus10);

            EmployeeStatusDictionary.Add(EmployeeStatus1.Id, EmployeeStatus1);
            EmployeeStatusDictionary.Add(EmployeeStatus2.Id, EmployeeStatus2);
            EmployeeStatusDictionary.Add(EmployeeStatus3.Id, EmployeeStatus3);
            EmployeeStatusDictionary.Add(EmployeeStatus4.Id, EmployeeStatus4);
            EmployeeStatusDictionary.Add(EmployeeStatus5.Id, EmployeeStatus5);
            EmployeeStatusDictionary.Add(EmployeeStatus6.Id, EmployeeStatus6);
            EmployeeStatusDictionary.Add(EmployeeStatus7.Id, EmployeeStatus7);
            EmployeeStatusDictionary.Add(EmployeeStatus8.Id, EmployeeStatus8);
            EmployeeStatusDictionary.Add(EmployeeStatus9.Id, EmployeeStatus9);
            EmployeeStatusDictionary.Add(EmployeeStatus10.Id, EmployeeStatus10);

        }
    }
}
