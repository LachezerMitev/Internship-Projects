using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AutoPart
{
    class AutoPartStorage : BaseStorage<Data.Entity.AutoPart, long>
    {
        public static List<Data.Entity.AutoPart> List = new List<Data.Entity.AutoPart>();
        public static Dictionary<long, Data.Entity.AutoPart> Dictionary = new Dictionary<long, Data.Entity.AutoPart>();

        static AutoPartStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\AutoParts.json");

<<<<<<< Updated upstream
            };

            Data.Entity.AutoPart AutoPart2 = new Data.Entity.AutoPart
            {
                
            };

            Data.Entity.AutoPart AutoPart3 = new Data.Entity.AutoPart
            {
               
            };
            Data.Entity.AutoPart AutoPart4 = new Data.Entity.AutoPart
            {
                
            };
            Data.Entity.AutoPart AutoPart5 = new Data.Entity.AutoPart
            {
                
            };
            Data.Entity.AutoPart AutoPart6 = new Data.Entity.AutoPart
            {
                
            };
            Data.Entity.AutoPart AutoPart7 = new Data.Entity.AutoPart
            {
                
            };
            Data.Entity.AutoPart AutoPart8 = new Data.Entity.AutoPart
            {
                
            };
            Data.Entity.AutoPart AutoPart9 = new Data.Entity.AutoPart
            {
                
            };
            Data.Entity.AutoPart AutoPart10 = new Data.Entity.AutoPart
            {
                
            };
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.AutoPart>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.AutoPart> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\AutoParts.json";
    }
}
