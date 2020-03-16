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

<<<<<<< Updated upstream
            Data.Entity.User User2 = new Data.Entity.User
            {
                Id = 21,
                Password = "123",
                Username = "Joro"
            };

            Data.Entity.User User3 = new Data.Entity.User
            {
                Id = 31,
                Password = "123",
                Username = "Joro"
            };
            Data.Entity.User User4 = new Data.Entity.User
            {
                Id = 41,
                Password = "123",
                Username = "Joro"
            };
            Data.Entity.User User5 = new Data.Entity.User
            {
                Id = 51,
                Password = "123",
                Username = "Joro"
            };
            Data.Entity.User User6 = new Data.Entity.User
            {
                Id = 61,
                Password = "123",
                Username = "Joro"
            };
            Data.Entity.User User7 = new Data.Entity.User
            {
                Id = 71,
                Password = "123",
                Username = "Joro"
            };
            Data.Entity.User User8 = new Data.Entity.User
            {
                Id = 81,
                Password = "123",
                Username = "Joro"
            };
            Data.Entity.User User9 = new Data.Entity.User
            {
                Id = 91,
                Password = "123",
                Username = "Joro"
            };
            Data.Entity.User User10 = new Data.Entity.User
            {
                Id = 101,
                Password = "123",
                Username = "Joro"
            };

            UserList.Add(User1);
            UserList.Add(User2);
            UserList.Add(User3);
            UserList.Add(User4);
            UserList.Add(User5);
            UserList.Add(User6);
            UserList.Add(User7);
            UserList.Add(User8);
            UserList.Add(User9);
            UserList.Add(User10);
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.User>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.User> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Users.json";
    }
}
