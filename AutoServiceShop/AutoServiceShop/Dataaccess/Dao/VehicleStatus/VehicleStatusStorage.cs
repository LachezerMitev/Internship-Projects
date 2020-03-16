using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.VehicleStatus
{
    class VehicleStatusStorage : BaseStorage<Data.Entity.VehicleStatus, long>
    {
        public static List<Data.Entity.VehicleStatus> List = new List<Data.Entity.VehicleStatus>();
        public static Dictionary<long, Data.Entity.VehicleStatus> Dictionary = new Dictionary<long, Data.Entity.VehicleStatus>();

        static VehicleStatusStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\VehicleStatuses.json");

<<<<<<< Updated upstream
            };

            Data.Entity.VehicleStatus VehicleStatus2 = new Data.Entity.VehicleStatus
            {

            };

            Data.Entity.VehicleStatus VehicleStatus3 = new Data.Entity.VehicleStatus
            {

            };
            Data.Entity.VehicleStatus VehicleStatus4 = new Data.Entity.VehicleStatus
            {

            };
            Data.Entity.VehicleStatus VehicleStatus5 = new Data.Entity.VehicleStatus
            {

            };
            Data.Entity.VehicleStatus VehicleStatus6 = new Data.Entity.VehicleStatus
            {

            };
            Data.Entity.VehicleStatus VehicleStatus7 = new Data.Entity.VehicleStatus
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.VehicleStatus>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.VehicleStatus> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\VehicleStatuses.json";
    }
}
