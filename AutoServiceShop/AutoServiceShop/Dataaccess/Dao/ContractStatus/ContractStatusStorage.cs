using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.ContractStatus
{
    class ContractStatusStorage
    {
        public static List<Data.Entity.ContractStatus> ContractStatusList = new List<Data.Entity.ContractStatus>();
        public static Dictionary<long, Data.Entity.ContractStatus> ContractStatusDictionary = new Dictionary<long, Data.Entity.ContractStatus>();

        static ContractStatusStorage()
        {
            Data.Entity.ContractStatus ContractStatus1 = new Data.Entity.ContractStatus
            {

<<<<<<< Updated upstream
            };

            Data.Entity.ContractStatus ContractStatus2 = new Data.Entity.ContractStatus
            {

            };

            Data.Entity.ContractStatus ContractStatus3 = new Data.Entity.ContractStatus
            {

            };
            Data.Entity.ContractStatus ContractStatus4 = new Data.Entity.ContractStatus
            {

            };
            Data.Entity.ContractStatus ContractStatus5 = new Data.Entity.ContractStatus
            {

            };
            Data.Entity.ContractStatus ContractStatus6 = new Data.Entity.ContractStatus
            {

            };
            Data.Entity.ContractStatus ContractStatus7 = new Data.Entity.ContractStatus
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.ContractStatus>>(json);
        }
>>>>>>> Stashed changes

            };
            Data.Entity.ContractStatus ContractStatus8 = new Data.Entity.ContractStatus
            {

            };
            Data.Entity.ContractStatus ContractStatus9 = new Data.Entity.ContractStatus
            {

            };
            Data.Entity.ContractStatus ContractStatus10 = new Data.Entity.ContractStatus
            {

            };

            ContractStatusList.Add(ContractStatus1);
            ContractStatusList.Add(ContractStatus2);
            ContractStatusList.Add(ContractStatus3);
            ContractStatusList.Add(ContractStatus4);
            ContractStatusList.Add(ContractStatus5);
            ContractStatusList.Add(ContractStatus6);
            ContractStatusList.Add(ContractStatus7);
            ContractStatusList.Add(ContractStatus8);
            ContractStatusList.Add(ContractStatus9);
            ContractStatusList.Add(ContractStatus10);

            ContractStatusDictionary.Add(ContractStatus1.Id, ContractStatus1);
            ContractStatusDictionary.Add(ContractStatus2.Id, ContractStatus2);
            ContractStatusDictionary.Add(ContractStatus3.Id, ContractStatus3);
            ContractStatusDictionary.Add(ContractStatus4.Id, ContractStatus4);
            ContractStatusDictionary.Add(ContractStatus5.Id, ContractStatus5);
            ContractStatusDictionary.Add(ContractStatus6.Id, ContractStatus6);
            ContractStatusDictionary.Add(ContractStatus7.Id, ContractStatus7);
            ContractStatusDictionary.Add(ContractStatus8.Id, ContractStatus8);
            ContractStatusDictionary.Add(ContractStatus9.Id, ContractStatus9);
            ContractStatusDictionary.Add(ContractStatus10.Id, ContractStatus10);

        }
    }
}
