using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.UserGroupStatus
{
    class UserGroupStatusStorage : BaseStorage<Data.Entity.UserGroupStatus, long>
    {
        public static List<Data.Entity.UserGroupStatus> List = new List<Data.Entity.UserGroupStatus>();
        public static Dictionary<long, Data.Entity.UserGroupStatus> Dictionary = new Dictionary<long, Data.Entity.UserGroupStatus>();

        static UserGroupStatusStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\UserGroupStatuses.json");

            List = JsonConvert.DeserializeObject<List<Data.Entity.UserGroupStatus>>(json);

            Dictionary = List.ToDictionary(x => x.Id, x => x);
        }

        public override Dictionary<long, Data.Entity.UserGroupStatus> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\UserGroupStatuses.json";
    }
}

