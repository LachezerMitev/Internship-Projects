using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AutoPartStatus
{
    class AutoPartStatusStorage : BaseStorage<Data.Entity.AutoPartStatus, long>
    {
        public static List<Data.Entity.AutoPartStatus> List = new List<Data.Entity.AutoPartStatus>();
        public static Dictionary<long, Data.Entity.AutoPartStatus> Dictionary = new Dictionary<long, Data.Entity.AutoPartStatus>();

        static AutoPartStatusStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\AutoPartStatuses.json");

<<<<<<< Updated upstream
            };

            Data.Entity.AutoPartStatus AutoPartStatus2 = new Data.Entity.AutoPartStatus
            {

            };

            Data.Entity.AutoPartStatus AutoPartStatus3 = new Data.Entity.AutoPartStatus
            {

            };
            Data.Entity.AutoPartStatus AutoPartStatus4 = new Data.Entity.AutoPartStatus
            {

            };
            Data.Entity.AutoPartStatus AutoPartStatus5 = new Data.Entity.AutoPartStatus
            {

            };
            Data.Entity.AutoPartStatus AutoPartStatus6 = new Data.Entity.AutoPartStatus
            {

            };
            Data.Entity.AutoPartStatus AutoPartStatus7 = new Data.Entity.AutoPartStatus
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.AutoPartStatus>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.AutoPartStatus> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\AutoPartStatuses.json";
    }
}
