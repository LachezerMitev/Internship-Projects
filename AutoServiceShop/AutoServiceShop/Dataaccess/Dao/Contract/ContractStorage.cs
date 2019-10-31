using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Contract
{
    class ContractStorage
    {
        public static List<Data.Entity.Contract> ContractList = new List<Data.Entity.Contract>();
        public static Dictionary<long, Data.Entity.Contract> ContractDictionary = new Dictionary<long, Data.Entity.Contract>();

        static ContractStorage()
        {
            Data.Entity.Contract Contract1 = new Data.Entity.Contract
            {

            };

            Data.Entity.Contract Contract2 = new Data.Entity.Contract
            {

            };

            Data.Entity.Contract Contract3 = new Data.Entity.Contract
            {

            };
            Data.Entity.Contract Contract4 = new Data.Entity.Contract
            {

            };
            Data.Entity.Contract Contract5 = new Data.Entity.Contract
            {

            };
            Data.Entity.Contract Contract6 = new Data.Entity.Contract
            {

            };
            Data.Entity.Contract Contract7 = new Data.Entity.Contract
            {

            };
            Data.Entity.Contract Contract8 = new Data.Entity.Contract
            {

            };
            Data.Entity.Contract Contract9 = new Data.Entity.Contract
            {

            };
            Data.Entity.Contract Contract10 = new Data.Entity.Contract
            {

            };

            ContractList.Add(Contract1);
            ContractList.Add(Contract2);
            ContractList.Add(Contract3);
            ContractList.Add(Contract4);
            ContractList.Add(Contract5);
            ContractList.Add(Contract6);
            ContractList.Add(Contract7);
            ContractList.Add(Contract8);
            ContractList.Add(Contract9);
            ContractList.Add(Contract10);

            ContractDictionary.Add(Contract1.Id, Contract1);
            ContractDictionary.Add(Contract2.Id, Contract2);
            ContractDictionary.Add(Contract3.Id, Contract3);
            ContractDictionary.Add(Contract4.Id, Contract4);
            ContractDictionary.Add(Contract5.Id, Contract5);
            ContractDictionary.Add(Contract6.Id, Contract6);
            ContractDictionary.Add(Contract7.Id, Contract7);
            ContractDictionary.Add(Contract8.Id, Contract8);
            ContractDictionary.Add(Contract9.Id, Contract9);
            ContractDictionary.Add(Contract10.Id, Contract10);

        }
    }
}
