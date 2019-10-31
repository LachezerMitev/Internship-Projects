using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.CheckUpStatus
{
    class CheckUpStatusStorage
    {
        public static List<Data.Entity.CheckUpStatus> CheckUpStatusList = new List<Data.Entity.CheckUpStatus>();
        public static Dictionary<long, Data.Entity.CheckUpStatus> CheckUpStatusDictionary = new Dictionary<long, Data.Entity.CheckUpStatus>();

        static CheckUpStatusStorage()
        {
            Data.Entity.CheckUpStatus CheckUpStatus1 = new Data.Entity.CheckUpStatus
            {

            };

            Data.Entity.CheckUpStatus CheckUpStatus2 = new Data.Entity.CheckUpStatus
            {

            };

            Data.Entity.CheckUpStatus CheckUpStatus3 = new Data.Entity.CheckUpStatus
            {

            };
            Data.Entity.CheckUpStatus CheckUpStatus4 = new Data.Entity.CheckUpStatus
            {

            };
            Data.Entity.CheckUpStatus CheckUpStatus5 = new Data.Entity.CheckUpStatus
            {

            };
            Data.Entity.CheckUpStatus CheckUpStatus6 = new Data.Entity.CheckUpStatus
            {

            };
            Data.Entity.CheckUpStatus CheckUpStatus7 = new Data.Entity.CheckUpStatus
            {

            };
            Data.Entity.CheckUpStatus CheckUpStatus8 = new Data.Entity.CheckUpStatus
            {

            };
            Data.Entity.CheckUpStatus CheckUpStatus9 = new Data.Entity.CheckUpStatus
            {

            };
            Data.Entity.CheckUpStatus CheckUpStatus10 = new Data.Entity.CheckUpStatus
            {

            };

            CheckUpStatusList.Add(CheckUpStatus1);
            CheckUpStatusList.Add(CheckUpStatus2);
            CheckUpStatusList.Add(CheckUpStatus3);
            CheckUpStatusList.Add(CheckUpStatus4);
            CheckUpStatusList.Add(CheckUpStatus5);
            CheckUpStatusList.Add(CheckUpStatus6);
            CheckUpStatusList.Add(CheckUpStatus7);
            CheckUpStatusList.Add(CheckUpStatus8);
            CheckUpStatusList.Add(CheckUpStatus9);
            CheckUpStatusList.Add(CheckUpStatus10);

            CheckUpStatusDictionary.Add(CheckUpStatus1.Id, CheckUpStatus1);
            CheckUpStatusDictionary.Add(CheckUpStatus2.Id, CheckUpStatus2);
            CheckUpStatusDictionary.Add(CheckUpStatus3.Id, CheckUpStatus3);
            CheckUpStatusDictionary.Add(CheckUpStatus4.Id, CheckUpStatus4);
            CheckUpStatusDictionary.Add(CheckUpStatus5.Id, CheckUpStatus5);
            CheckUpStatusDictionary.Add(CheckUpStatus6.Id, CheckUpStatus6);
            CheckUpStatusDictionary.Add(CheckUpStatus7.Id, CheckUpStatus7);
            CheckUpStatusDictionary.Add(CheckUpStatus8.Id, CheckUpStatus8);
            CheckUpStatusDictionary.Add(CheckUpStatus9.Id, CheckUpStatus9);
            CheckUpStatusDictionary.Add(CheckUpStatus10.Id, CheckUpStatus10);

        }
    }
}
