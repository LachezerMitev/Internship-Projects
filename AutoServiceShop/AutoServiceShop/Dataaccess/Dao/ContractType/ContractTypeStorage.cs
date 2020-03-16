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

<<<<<<< Updated upstream
            };

            Data.Entity.ContractType ContractType2 = new Data.Entity.ContractType
            {

            };

            Data.Entity.ContractType ContractType3 = new Data.Entity.ContractType
            {

            };
            Data.Entity.ContractType ContractType4 = new Data.Entity.ContractType
            {

            };
            Data.Entity.ContractType ContractType5 = new Data.Entity.ContractType
            {

            };
            Data.Entity.ContractType ContractType6 = new Data.Entity.ContractType
            {

            };
            Data.Entity.ContractType ContractType7 = new Data.Entity.ContractType
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.ContractType>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.ContractType> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\ContractTypes.json";
    }
}
