using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Model
{
    class ModelStorage : BaseStorage<Data.Entity.Model, long>
    {
        public static List<Data.Entity.Model> List = new List<Data.Entity.Model>();
        public static Dictionary<long, Data.Entity.Model> Dictionary = new Dictionary<long, Data.Entity.Model>();

        static ModelStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Models.json");

            List = JsonConvert.DeserializeObject<List<Data.Entity.Model>>(json);

            Dictionary = List.ToDictionary(x => x.Id, x => x);
        }

        public override Dictionary<long, Data.Entity.Model> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Models.json";
    }
}
