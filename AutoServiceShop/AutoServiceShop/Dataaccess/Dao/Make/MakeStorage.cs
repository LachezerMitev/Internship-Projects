using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Make
{
    class MakeStorage : BaseStorage<Data.Entity.Make, long>
    {
        public static List<Data.Entity.Make> List = new List<Data.Entity.Make>();
        public static Dictionary<long, Data.Entity.Make> Dictionary = new Dictionary<long, Data.Entity.Make>();

        static MakeStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Makes.json");

            List = JsonConvert.DeserializeObject<List<Data.Entity.Make>>(json);

            Dictionary = List.ToDictionary(x => x.Id, x => x);
        }

        public override Dictionary<long, Data.Entity.Make> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Makes.json";
    }
}
