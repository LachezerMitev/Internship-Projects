using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AccountType
{
    class AccountTypeStorage : BaseStorage<Data.Entity.AccountType, long>
    {
        public static List<Data.Entity.AccountType> List = new List<Data.Entity.AccountType>();
        public static Dictionary<long, Data.Entity.AccountType> Dictionary = new Dictionary<long, Data.Entity.AccountType>();

        static AccountTypeStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\AccountTypes.json");

            List = JsonConvert.DeserializeObject<List<Data.Entity.AccountType>>(json);

            Dictionary = List.ToDictionary(x => x.Id, x => x);
        }

        public override Dictionary<long, Data.Entity.AccountType> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\AccountTypes.json";
    }
}
