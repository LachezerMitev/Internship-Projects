using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.ContractStatus
{
    class ContractStatusStorage : BaseStorage<Data.Entity.ContractStatus, long>
    {
        public static List<Data.Entity.ContractStatus> List = new List<Data.Entity.ContractStatus>();
        public static Dictionary<long, Data.Entity.ContractStatus> Dictionary = new Dictionary<long, Data.Entity.ContractStatus>();

        static ContractStatusStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\ContractStatuses.json");

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

        public override Dictionary<long, Data.Entity.ContractStatus> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\ContractStatuses.json";
    }
}
