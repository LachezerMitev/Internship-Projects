using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.VehicleMakeModel
{
    class VehicleMakeModelStorage : BaseStorage<Data.Entity.VehicleMakeModel, long>
    {
        public static List<Data.Entity.VehicleMakeModel> List = new List<Data.Entity.VehicleMakeModel>();
        public static Dictionary<long, Data.Entity.VehicleMakeModel> Dictionary = new Dictionary<long, Data.Entity.VehicleMakeModel>();

        static VehicleMakeModelStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\VehicleMakeModels.json");

            List = JsonConvert.DeserializeObject<List<Data.Entity.VehicleMakeModel>>(json);

            Dictionary = List.ToDictionary(x => x.Id, x => x);
        }

        public override Dictionary<long, Data.Entity.VehicleMakeModel> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\VehicleMakeModels.json";
    }
}
