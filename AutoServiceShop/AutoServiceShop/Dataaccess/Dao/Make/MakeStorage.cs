using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Make
{
    class MakeStorage : BaseStorage<Data.Entity.Make, long>
    {
        public static List<Data.Entity.Make> List = new List<Data.Entity.Make>();
        public static Dictionary<long, Data.Entity.Make> Dictionary = new Dictionary<long, Data.Entity.Make>();

        static MakeStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Makes.json");

<<<<<<< Updated upstream
            };

            Data.Entity.Make Make2 = new Data.Entity.Make
            {

            };

            Data.Entity.Make Make3 = new Data.Entity.Make
            {

            };
            Data.Entity.Make Make4 = new Data.Entity.Make
            {

            };
            Data.Entity.Make Make5 = new Data.Entity.Make
            {

            };
            Data.Entity.Make Make6 = new Data.Entity.Make
            {

            };
            Data.Entity.Make Make7 = new Data.Entity.Make
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.Make>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.Make> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Makes.json";
    }
}
