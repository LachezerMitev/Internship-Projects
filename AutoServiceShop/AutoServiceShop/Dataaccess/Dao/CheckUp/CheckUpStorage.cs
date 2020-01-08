using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.CheckUp
{
    class CheckUpStorage : BaseStorage<Data.Entity.CheckUp, long>
    {
        public static List<Data.Entity.CheckUp> List = new List<Data.Entity.CheckUp>();
        public static Dictionary<long, Data.Entity.CheckUp> Dictionary = new Dictionary<long, Data.Entity.CheckUp>();

        static CheckUpStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\CheckUps.json");

            List = JsonConvert.DeserializeObject<List<Data.Entity.CheckUp>>(json);

            Dictionary = List.ToDictionary(x => x.Id, x => x);
        }

        public override Dictionary<long, Data.Entity.CheckUp> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\CheckUps.json";
    }
}
