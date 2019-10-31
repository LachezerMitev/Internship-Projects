using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AutoPartStatus
{
    class AutoPartStatusStorage
    {
        public static List<Data.Entity.AutoPartStatus> AutoPartStatusList = new List<Data.Entity.AutoPartStatus>();
        public static Dictionary<long, Data.Entity.AutoPartStatus> AutoPartStatusDictionary = new Dictionary<long, Data.Entity.AutoPartStatus>();

        static AutoPartStatusStorage()
        {
            Data.Entity.AutoPartStatus AutoPartStatus1 = new Data.Entity.AutoPartStatus
            {

            };

            Data.Entity.AutoPartStatus AutoPartStatus2 = new Data.Entity.AutoPartStatus
            {

            };

            Data.Entity.AutoPartStatus AutoPartStatus3 = new Data.Entity.AutoPartStatus
            {

            };
            Data.Entity.AutoPartStatus AutoPartStatus4 = new Data.Entity.AutoPartStatus
            {

            };
            Data.Entity.AutoPartStatus AutoPartStatus5 = new Data.Entity.AutoPartStatus
            {

            };
            Data.Entity.AutoPartStatus AutoPartStatus6 = new Data.Entity.AutoPartStatus
            {

            };
            Data.Entity.AutoPartStatus AutoPartStatus7 = new Data.Entity.AutoPartStatus
            {

            };
            Data.Entity.AutoPartStatus AutoPartStatus8 = new Data.Entity.AutoPartStatus
            {

            };
            Data.Entity.AutoPartStatus AutoPartStatus9 = new Data.Entity.AutoPartStatus
            {

            };
            Data.Entity.AutoPartStatus AutoPartStatus10 = new Data.Entity.AutoPartStatus
            {

            };

            AutoPartStatusList.Add(AutoPartStatus1);
            AutoPartStatusList.Add(AutoPartStatus2);
            AutoPartStatusList.Add(AutoPartStatus3);
            AutoPartStatusList.Add(AutoPartStatus4);
            AutoPartStatusList.Add(AutoPartStatus5);
            AutoPartStatusList.Add(AutoPartStatus6);
            AutoPartStatusList.Add(AutoPartStatus7);
            AutoPartStatusList.Add(AutoPartStatus8);
            AutoPartStatusList.Add(AutoPartStatus9);
            AutoPartStatusList.Add(AutoPartStatus10);

            AutoPartStatusDictionary.Add(AutoPartStatus1.Id, AutoPartStatus1);
            AutoPartStatusDictionary.Add(AutoPartStatus2.Id, AutoPartStatus2);
            AutoPartStatusDictionary.Add(AutoPartStatus3.Id, AutoPartStatus3);
            AutoPartStatusDictionary.Add(AutoPartStatus4.Id, AutoPartStatus4);
            AutoPartStatusDictionary.Add(AutoPartStatus5.Id, AutoPartStatus5);
            AutoPartStatusDictionary.Add(AutoPartStatus6.Id, AutoPartStatus6);
            AutoPartStatusDictionary.Add(AutoPartStatus7.Id, AutoPartStatus7);
            AutoPartStatusDictionary.Add(AutoPartStatus8.Id, AutoPartStatus8);
            AutoPartStatusDictionary.Add(AutoPartStatus9.Id, AutoPartStatus9);
            AutoPartStatusDictionary.Add(AutoPartStatus10.Id, AutoPartStatus10);

        }
    }
}
