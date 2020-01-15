using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.UserGroup
{
    class UserGroupStorage
    {
        public static List<Data.Entity.UserGroup> UserGroupList = new List<Data.Entity.UserGroup>();
        public static Dictionary<long, Data.Entity.UserGroup> UserGroupDictionary = new Dictionary<long, Data.Entity.UserGroup>();

        static UserGroupStorage()
        {
            Data.Entity.UserGroup UserGroup1 = new Data.Entity.UserGroup
            {

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

            };
            Data.Entity.UserGroup UserGroup8 = new Data.Entity.UserGroup
            {

            };
            Data.Entity.UserGroup UserGroup9 = new Data.Entity.UserGroup
            {

            };
            Data.Entity.UserGroup UserGroup10 = new Data.Entity.UserGroup
            {

            };

            UserGroupList.Add(UserGroup1);
            UserGroupList.Add(UserGroup2);
            UserGroupList.Add(UserGroup3);
            UserGroupList.Add(UserGroup4);
            UserGroupList.Add(UserGroup5);
            UserGroupList.Add(UserGroup6);
            UserGroupList.Add(UserGroup7);
            UserGroupList.Add(UserGroup8);
            UserGroupList.Add(UserGroup9);
            UserGroupList.Add(UserGroup10);

            UserGroupDictionary.Add(UserGroup1.Id, UserGroup1);
            UserGroupDictionary.Add(UserGroup2.Id, UserGroup2);
            UserGroupDictionary.Add(UserGroup3.Id, UserGroup3);
            UserGroupDictionary.Add(UserGroup4.Id, UserGroup4);
            UserGroupDictionary.Add(UserGroup5.Id, UserGroup5);
            UserGroupDictionary.Add(UserGroup6.Id, UserGroup6);
            UserGroupDictionary.Add(UserGroup7.Id, UserGroup7);
            UserGroupDictionary.Add(UserGroup8.Id, UserGroup8);
            UserGroupDictionary.Add(UserGroup9.Id, UserGroup9);
            UserGroupDictionary.Add(UserGroup10.Id, UserGroup10);

        }
    }
}
