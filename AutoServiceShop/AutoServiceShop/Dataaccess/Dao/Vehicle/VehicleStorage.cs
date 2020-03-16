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

<<<<<<< Updated upstream
            };

            Data.Entity.Vehicle Vehicle2 = new Data.Entity.Vehicle
            {

            };

            Data.Entity.Vehicle Vehicle3 = new Data.Entity.Vehicle
            {

            };
            Data.Entity.Vehicle Vehicle4 = new Data.Entity.Vehicle
            {

            };
            Data.Entity.Vehicle Vehicle5 = new Data.Entity.Vehicle
            {

            };
            Data.Entity.Vehicle Vehicle6 = new Data.Entity.Vehicle
            {

            };
            Data.Entity.Vehicle Vehicle7 = new Data.Entity.Vehicle
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.Vehicle>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.Vehicle> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Vehicles.json";
    }
}
