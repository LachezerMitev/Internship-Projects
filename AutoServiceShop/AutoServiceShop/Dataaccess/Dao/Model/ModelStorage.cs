using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Model
{
    class ModelStorage : BaseStorage<Data.Entity.Model, long>
    {
        public static List<Data.Entity.Model> List = new List<Data.Entity.Model>();
        public static Dictionary<long, Data.Entity.Model> Dictionary = new Dictionary<long, Data.Entity.Model>();

        static ModelStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Models.json");

<<<<<<< Updated upstream
            };

            Data.Entity.Model Model2 = new Data.Entity.Model
            {

            };

            Data.Entity.Model Model3 = new Data.Entity.Model
            {

            };
            Data.Entity.Model Model4 = new Data.Entity.Model
            {

            };
            Data.Entity.Model Model5 = new Data.Entity.Model
            {

            };
            Data.Entity.Model Model6 = new Data.Entity.Model
            {

            };
            Data.Entity.Model Model7 = new Data.Entity.Model
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.Model>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.Model> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Models.json";
    }
}
