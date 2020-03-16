using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Contract
{
    class ContractStorage : BaseStorage<Data.Entity.Contract, long>
    {
        public static List<Data.Entity.Contract> List = new List<Data.Entity.Contract>();
        public static Dictionary<long, Data.Entity.Contract> Dictionary = new Dictionary<long, Data.Entity.Contract>();

        static ContractStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Contracts.json");

<<<<<<< Updated upstream
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
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.Contract>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.Contract> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Contracts.json";
    }
}
