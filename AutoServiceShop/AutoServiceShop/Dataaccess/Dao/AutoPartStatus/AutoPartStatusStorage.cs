using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AutoPartStatus
{
    class AutoPartStatusStorage : BaseStorage<Data.Entity.AutoPartStatus, long>
    {
        public static List<Data.Entity.AutoPartStatus> List = new List<Data.Entity.AutoPartStatus>();
        public static Dictionary<long, Data.Entity.AutoPartStatus> Dictionary = new Dictionary<long, Data.Entity.AutoPartStatus>();

        static AutoPartStatusStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\AutoPartStatuses.json");

            List = JsonConvert.DeserializeObject<List<Data.Entity.AutoPartStatus>>(json);

            Dictionary = List.ToDictionary(x => x.Id, x => x);
        }

        public override Dictionary<long, Data.Entity.AutoPartStatus> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\AutoPartStatuses.json";
    }
}
