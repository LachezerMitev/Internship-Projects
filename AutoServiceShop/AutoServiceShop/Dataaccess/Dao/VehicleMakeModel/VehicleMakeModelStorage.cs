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

<<<<<<< Updated upstream
            };

            Data.Entity.VehicleMakeModel VehicleMakeModel2 = new Data.Entity.VehicleMakeModel
            {

            };

            Data.Entity.VehicleMakeModel VehicleMakeModel3 = new Data.Entity.VehicleMakeModel
            {

            };
            Data.Entity.VehicleMakeModel VehicleMakeModel4 = new Data.Entity.VehicleMakeModel
            {

            };
            Data.Entity.VehicleMakeModel VehicleMakeModel5 = new Data.Entity.VehicleMakeModel
            {

            };
            Data.Entity.VehicleMakeModel VehicleMakeModel6 = new Data.Entity.VehicleMakeModel
            {

            };
            Data.Entity.VehicleMakeModel VehicleMakeModel7 = new Data.Entity.VehicleMakeModel
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.VehicleMakeModel>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.VehicleMakeModel> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\VehicleMakeModels.json";
    }
}
