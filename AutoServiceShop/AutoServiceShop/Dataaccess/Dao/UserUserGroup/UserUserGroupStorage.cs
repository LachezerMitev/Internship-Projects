using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.UserUserGroup
{
    class UserUserGroupStorage : BaseStorage<Data.Entity.UserUserGroup, long>
    {
        public static List<Data.Entity.UserUserGroup> List = new List<Data.Entity.UserUserGroup>();
        public static Dictionary<long, Data.Entity.UserUserGroup> Dictionary = new Dictionary<long, Data.Entity.UserUserGroup>();

        static UserUserGroupStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\UserUserGroups.json");

<<<<<<< Updated upstream
            };

            Data.Entity.UserUserGroup UserUserGroup2 = new Data.Entity.UserUserGroup
            {

            };

            Data.Entity.UserUserGroup UserUserGroup3 = new Data.Entity.UserUserGroup
            {

            };
            Data.Entity.UserUserGroup UserUserGroup4 = new Data.Entity.UserUserGroup
            {

            };
            Data.Entity.UserUserGroup UserUserGroup5 = new Data.Entity.UserUserGroup
            {

            };
            Data.Entity.UserUserGroup UserUserGroup6 = new Data.Entity.UserUserGroup
            {

            };
            Data.Entity.UserUserGroup UserUserGroup7 = new Data.Entity.UserUserGroup
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.UserUserGroup>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.UserUserGroup> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\UserUserGroups.json";
    }
}
