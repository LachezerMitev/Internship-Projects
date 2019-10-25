using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AccountStatus
{
    class AccountStatusStorage
    {
        public static List<Data.Entity.AccountStatus> AccountStatusList = new List<Data.Entity.AccountStatus>();
        public static Dictionary<long, Data.Entity.AccountStatus> AccountStatusDictionary = new Dictionary<long, Data.Entity.AccountStatus>();

        static AccountStatusStorage()
        {
            Data.Entity.AccountStatus accountStatus1 = new Data.Entity.AccountStatus
            {
                Code = "ASCI",
                Description = "Well, He works...... stuff..... idk",
                Name = "Georgi",
                Id = 12352456
            };

            Data.Entity.AccountStatus accountStatus2 = new Data.Entity.AccountStatus
            {
                Code = "ASCI",
                Description = "Active",
                Name = "Ivan",
                Id = 14573574
            };

            Data.Entity.AccountStatus accountStatus3 = new Data.Entity.AccountStatus
            {
                Code = "DOBF",
                Description = "Active",
                Name = "Petar",
                Id = 0157617
            };
            Data.Entity.AccountStatus accountStatus4 = new Data.Entity.AccountStatus
            {
                Code = "SASS",
                Description = "Inactive",
                Name = "Mitko",
                Id = 0128674
            };
            Data.Entity.AccountStatus accountStatus5 = new Data.Entity.AccountStatus
            {
                Code = "IDFA",
                Description = "Active",
                Name = "Mitko",
                Id = 254685
            };
            Data.Entity.AccountStatus accountStatus6 = new Data.Entity.AccountStatus
            {
                Code = "DFON",
                Description = "Active",
                Name = "Joro",
                Id = 348652
            };
            Data.Entity.AccountStatus accountStatus7 = new Data.Entity.AccountStatus
            {
                Code = "SPZN",
                Description = "Active",
                Name = "Joro",
                Id = 348952
            };
            Data.Entity.AccountStatus accountStatus8 = new Data.Entity.AccountStatus
            {
                Code = "STRL",
                Description = "Inactive",
                Name = "Gergi",
                Id = 145326
            };
            Data.Entity.AccountStatus accountStatus9 = new Data.Entity.AccountStatus
            {
                Code = "ODIN",
                Description = "Inactive",
                Name = "Stanislav",
                Id = 12352456
            };
            Data.Entity.AccountStatus accountStatus10 = new Data.Entity.AccountStatus
            {
                Code = "ARES",
                Description = "Inactive",
                Name = "Tedo",
                Id = 145367
            };

            AccountStatusList.Add(accountStatus1);
            AccountStatusList.Add(accountStatus2);
            AccountStatusList.Add(accountStatus3);
            AccountStatusList.Add(accountStatus4);
            AccountStatusList.Add(accountStatus5);
            AccountStatusList.Add(accountStatus6);
            AccountStatusList.Add(accountStatus7);
            AccountStatusList.Add(accountStatus8);
            AccountStatusList.Add(accountStatus9);
            AccountStatusList.Add(accountStatus10);

            AccountStatusDictionary.Add(accountStatus1.Id, accountStatus1);
            AccountStatusDictionary.Add(accountStatus2.Id, accountStatus2);
            AccountStatusDictionary.Add(accountStatus3.Id, accountStatus3);
            AccountStatusDictionary.Add(accountStatus4.Id, accountStatus4);
            AccountStatusDictionary.Add(accountStatus5.Id, accountStatus5);
            AccountStatusDictionary.Add(accountStatus6.Id, accountStatus6);
            AccountStatusDictionary.Add(accountStatus7.Id, accountStatus7);
            AccountStatusDictionary.Add(accountStatus8.Id, accountStatus8);
            AccountStatusDictionary.Add(accountStatus9.Id, accountStatus9);
            AccountStatusDictionary.Add(accountStatus10.Id, accountStatus10);

        }
    }
}
