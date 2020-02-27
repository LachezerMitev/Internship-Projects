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
<<<<<<< Updated upstream
            Data.Entity.AccountStatus accountStatus1 = new Data.Entity.AccountStatus
            {
                Code = "ASCI",
                Description = "Well, He works...... stuff..... idk",
                Name = "Working",
                Id = 1
            };

            Data.Entity.AccountStatus accountStatus2 = new Data.Entity.AccountStatus
            {
                Code = "ASCI",
                Description = "Active",
                Name = "Working",
                Id = 2
            };

            Data.Entity.AccountStatus accountStatus3 = new Data.Entity.AccountStatus
            {
                Code = "DOBF",
                Description = "Active",
                Name = "Working",
                Id = 3
            };
            Data.Entity.AccountStatus accountStatus4 = new Data.Entity.AccountStatus
            {
                Code = "SASS",
                Description = "Inactive",
                Name = "Idle",
                Id = 4
            };
            Data.Entity.AccountStatus accountStatus5 = new Data.Entity.AccountStatus
            {
                Code = "IDFA",
                Description = "Active",
                Name = "Working",
                Id = 5
            };
            Data.Entity.AccountStatus accountStatus6 = new Data.Entity.AccountStatus
            {
                Code = "DFON",
                Description = "Active",
                Name = "Ill",
                Id = 6
            };
            Data.Entity.AccountStatus accountStatus7 = new Data.Entity.AccountStatus
            {
                Code = "SPZN",
                Description = "Active",
                Name = "Working",
                Id = 7
            };
            Data.Entity.AccountStatus accountStatus8 = new Data.Entity.AccountStatus
            {
                Code = "STRL",
                Description = "Inactive",
                Name = "Idle",
                Id = 8
            };
            Data.Entity.AccountStatus accountStatus9 = new Data.Entity.AccountStatus
            {
                Code = "ODIN",
                Description = "Inactive",
                Name = "Idle",
                Id = 9
            };
            Data.Entity.AccountStatus accountStatus10 = new Data.Entity.AccountStatus
            {
                Code = "ARES",
                Description = "Inactive",
                Name = "Working",
                Id = 10
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
=======
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\AccountStatuses.json");

            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.AccountStatus>>(json);
        }
>>>>>>> Stashed changes

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
