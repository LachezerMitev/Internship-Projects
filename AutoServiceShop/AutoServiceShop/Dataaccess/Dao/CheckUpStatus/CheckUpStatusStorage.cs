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

<<<<<<< Updated upstream
            };

            Data.Entity.CheckUpStatus CheckUpStatus2 = new Data.Entity.CheckUpStatus
            {

            };

            Data.Entity.CheckUpStatus CheckUpStatus3 = new Data.Entity.CheckUpStatus
            {

            };
            Data.Entity.CheckUpStatus CheckUpStatus4 = new Data.Entity.CheckUpStatus
            {

            };
            Data.Entity.CheckUpStatus CheckUpStatus5 = new Data.Entity.CheckUpStatus
            {

            };
            Data.Entity.CheckUpStatus CheckUpStatus6 = new Data.Entity.CheckUpStatus
            {

            };
            Data.Entity.CheckUpStatus CheckUpStatus7 = new Data.Entity.CheckUpStatus
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.CheckUpStatus>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.CheckUpStatus> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\CheckUpStatuses.json";
    }
}
