using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.UserGroup
{
    class UserGroupStorage : BaseStorage<Data.Entity.UserGroup, long>
    {
        public static List<Data.Entity.UserGroup> List = new List<Data.Entity.UserGroup>();
        public static Dictionary<long, Data.Entity.UserGroup> Dictionary = new Dictionary<long, Data.Entity.UserGroup>();

        static UserGroupStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\UserGroups.json");

<<<<<<< Updated upstream
            };

            Data.Entity.UserGroup UserGroup2 = new Data.Entity.UserGroup
            {

            };

            Data.Entity.UserGroup UserGroup3 = new Data.Entity.UserGroup
            {

            };
            Data.Entity.UserGroup UserGroup4 = new Data.Entity.UserGroup
            {

            };
            Data.Entity.UserGroup UserGroup5 = new Data.Entity.UserGroup
            {

            };
            Data.Entity.UserGroup UserGroup6 = new Data.Entity.UserGroup
            {

            };
            Data.Entity.UserGroup UserGroup7 = new Data.Entity.UserGroup
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.UserGroup>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.UserGroup> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\UserGroups.json";
    }
}
