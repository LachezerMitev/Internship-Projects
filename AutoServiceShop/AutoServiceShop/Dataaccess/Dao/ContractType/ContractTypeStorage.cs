using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.ContractType
{
    class ContractTypeStorage : BaseStorage<Data.Entity.ContractType, long>
    {
        public static List<Data.Entity.ContractType> List = new List<Data.Entity.ContractType>();
        public static Dictionary<long, Data.Entity.ContractType> Dictionary = new Dictionary<long, Data.Entity.ContractType>();

        static ContractTypeStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\ContractTypes.json");

            List = JsonConvert.DeserializeObject<List<Data.Entity.ContractType>>(json);

            Dictionary = List.ToDictionary(x => x.Id, x => x);
        }

        public override Dictionary<long, Data.Entity.ContractType> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\ContractTypes.json";
    }
}
