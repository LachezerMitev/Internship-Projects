using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Vehicle
{
    class VehicleStorage : BaseStorage<Data.Entity.Vehicle, long>
    {
        public static List<Data.Entity.Vehicle> List = new List<Data.Entity.Vehicle>();
        public static Dictionary<long, Data.Entity.Vehicle> Dictionary = new Dictionary<long, Data.Entity.Vehicle>();

        static VehicleStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Vehicles.json");

            List = JsonConvert.DeserializeObject<List<Data.Entity.Vehicle>>(json);

            Dictionary = List.ToDictionary(x => x.Id, x => x);
        }

        public override Dictionary<long, Data.Entity.Vehicle> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Vehicles.json";
    }
}
