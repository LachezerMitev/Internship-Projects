using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.User
{
    class UserStorage : BaseStorage<Data.Entity.User, long>
    {
        public static List<Data.Entity.User> List = new List<Data.Entity.User>();
        public static Dictionary<long, Data.Entity.User> Dictionary = new Dictionary<long, Data.Entity.User>();

        static UserStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Users.json");

            List = JsonConvert.DeserializeObject<List<Data.Entity.User>>(json);

            Dictionary = List.ToDictionary(x => x.Id, x => x);
        }

        public override Dictionary<long, Data.Entity.User> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Users.json";
    }
}
