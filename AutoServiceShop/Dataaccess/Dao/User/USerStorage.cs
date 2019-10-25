using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.User
{
    class UserStorage
    {
        public static List<Data.Entity.User> UserList = new List<Data.Entity.User>();
        public static Dictionary<long, Data.Entity.User> UserDictionary = new Dictionary<long, Data.Entity.User>();

        static UserStorage()
        {
            Data.Entity.User User1 = new Data.Entity.User
            {

            };

            Data.Entity.User User2 = new Data.Entity.User
            {

            };

            Data.Entity.User User3 = new Data.Entity.User
            {

            };
            Data.Entity.User User4 = new Data.Entity.User
            {

            };
            Data.Entity.User User5 = new Data.Entity.User
            {

            };
            Data.Entity.User User6 = new Data.Entity.User
            {

            };
            Data.Entity.User User7 = new Data.Entity.User
            {

            };
            Data.Entity.User User8 = new Data.Entity.User
            {

            };
            Data.Entity.User User9 = new Data.Entity.User
            {

            };
            Data.Entity.User User10 = new Data.Entity.User
            {

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

            UserDictionary.Add(User1.Id, User1);
            UserDictionary.Add(User2.Id, User2);
            UserDictionary.Add(User3.Id, User3);
            UserDictionary.Add(User4.Id, User4);
            UserDictionary.Add(User5.Id, User5);
            UserDictionary.Add(User6.Id, User6);
            UserDictionary.Add(User7.Id, User7);
            UserDictionary.Add(User8.Id, User8);
            UserDictionary.Add(User9.Id, User9);
            UserDictionary.Add(User10.Id, User10);

        }
    }
}
