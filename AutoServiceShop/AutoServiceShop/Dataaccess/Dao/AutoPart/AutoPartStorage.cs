using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AutoPart
{
    class AutoPartStorage : BaseStorage<Data.Entity.AutoPart, long>
    {
        public static List<Data.Entity.AutoPart> List = new List<Data.Entity.AutoPart>();
        public static Dictionary<long, Data.Entity.AutoPart> Dictionary = new Dictionary<long, Data.Entity.AutoPart>();

        static AutoPartStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\AutoParts.json");

            List = JsonConvert.DeserializeObject<List<Data.Entity.AutoPart>>(json);

            Dictionary = List.ToDictionary(x => x.Id, x => x);
        }

        public override Dictionary<long, Data.Entity.AutoPart> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\AutoParts.json";
    }
}
