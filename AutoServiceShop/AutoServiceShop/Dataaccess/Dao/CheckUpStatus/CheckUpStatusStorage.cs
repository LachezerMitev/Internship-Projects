using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.CheckUpStatus
{
    class CheckUpStatusStorage : BaseStorage<Data.Entity.CheckUpStatus, long>
    {
        public static List<Data.Entity.CheckUpStatus> List = new List<Data.Entity.CheckUpStatus>();
        public static Dictionary<long, Data.Entity.CheckUpStatus> Dictionary = new Dictionary<long, Data.Entity.CheckUpStatus>();

        static CheckUpStatusStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\CheckUpStatuses.json");

            List = JsonConvert.DeserializeObject<List<Data.Entity.CheckUpStatus>>(json);

            Dictionary = List.ToDictionary(x => x.Id, x => x);
        }

        public override Dictionary<long, Data.Entity.CheckUpStatus> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\CheckUpStatuses.json";
    }
}
