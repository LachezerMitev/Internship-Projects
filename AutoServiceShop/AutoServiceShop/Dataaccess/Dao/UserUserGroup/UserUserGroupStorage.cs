using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.UserUserGroup
{
    class UserUserGroupStorage
    {
        public static List<Data.Entity.UserUserGroup> UserUserGroupList = new List<Data.Entity.UserUserGroup>();
        public static Dictionary<long, Data.Entity.UserUserGroup> UserUserGroupDictionary = new Dictionary<long, Data.Entity.UserUserGroup>();

        static UserUserGroupStorage()
        {
            Data.Entity.UserUserGroup UserUserGroup1 = new Data.Entity.UserUserGroup
            {

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

            };
            Data.Entity.UserUserGroup UserUserGroup8 = new Data.Entity.UserUserGroup
            {

            };
            Data.Entity.UserUserGroup UserUserGroup9 = new Data.Entity.UserUserGroup
            {

            };
            Data.Entity.UserUserGroup UserUserGroup10 = new Data.Entity.UserUserGroup
            {

            };

            UserUserGroupList.Add(UserUserGroup1);
            UserUserGroupList.Add(UserUserGroup2);
            UserUserGroupList.Add(UserUserGroup3);
            UserUserGroupList.Add(UserUserGroup4);
            UserUserGroupList.Add(UserUserGroup5);
            UserUserGroupList.Add(UserUserGroup6);
            UserUserGroupList.Add(UserUserGroup7);
            UserUserGroupList.Add(UserUserGroup8);
            UserUserGroupList.Add(UserUserGroup9);
            UserUserGroupList.Add(UserUserGroup10);

            UserUserGroupDictionary.Add(UserUserGroup1.Id, UserUserGroup1);
            UserUserGroupDictionary.Add(UserUserGroup2.Id, UserUserGroup2);
            UserUserGroupDictionary.Add(UserUserGroup3.Id, UserUserGroup3);
            UserUserGroupDictionary.Add(UserUserGroup4.Id, UserUserGroup4);
            UserUserGroupDictionary.Add(UserUserGroup5.Id, UserUserGroup5);
            UserUserGroupDictionary.Add(UserUserGroup6.Id, UserUserGroup6);
            UserUserGroupDictionary.Add(UserUserGroup7.Id, UserUserGroup7);
            UserUserGroupDictionary.Add(UserUserGroup8.Id, UserUserGroup8);
            UserUserGroupDictionary.Add(UserUserGroup9.Id, UserUserGroup9);
            UserUserGroupDictionary.Add(UserUserGroup10.Id, UserUserGroup10);

        }
    }
}
