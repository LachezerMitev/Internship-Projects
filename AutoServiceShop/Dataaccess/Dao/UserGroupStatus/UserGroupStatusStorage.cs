using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.UserGroupStatus
{
    class UserGroupStatusStorage
    {
        public static List<Data.Entity.UserGroupStatus> UserGroupStatusList = new List<Data.Entity.UserGroupStatus>();
        public static Dictionary<long, Data.Entity.UserGroupStatus> UserGroupStatusDictionary = new Dictionary<long, Data.Entity.UserGroupStatus>();

        static UserGroupStatusStorage()
        {
            Data.Entity.UserGroupStatus UserGroupStatus1 = new Data.Entity.UserGroupStatus
            {

            };

            Data.Entity.UserGroupStatus UserGroupStatus2 = new Data.Entity.UserGroupStatus
            {

            };

            Data.Entity.UserGroupStatus UserGroupStatus3 = new Data.Entity.UserGroupStatus
            {

            };
            Data.Entity.UserGroupStatus UserGroupStatus4 = new Data.Entity.UserGroupStatus
            {

            };
            Data.Entity.UserGroupStatus UserGroupStatus5 = new Data.Entity.UserGroupStatus
            {

            };
            Data.Entity.UserGroupStatus UserGroupStatus6 = new Data.Entity.UserGroupStatus
            {

            };
            Data.Entity.UserGroupStatus UserGroupStatus7 = new Data.Entity.UserGroupStatus
            {

            };
            Data.Entity.UserGroupStatus UserGroupStatus8 = new Data.Entity.UserGroupStatus
            {

            };
            Data.Entity.UserGroupStatus UserGroupStatus9 = new Data.Entity.UserGroupStatus
            {

            };
            Data.Entity.UserGroupStatus UserGroupStatus10 = new Data.Entity.UserGroupStatus
            {

            };

            UserGroupStatusList.Add(UserGroupStatus1);
            UserGroupStatusList.Add(UserGroupStatus2);
            UserGroupStatusList.Add(UserGroupStatus3);
            UserGroupStatusList.Add(UserGroupStatus4);
            UserGroupStatusList.Add(UserGroupStatus5);
            UserGroupStatusList.Add(UserGroupStatus6);
            UserGroupStatusList.Add(UserGroupStatus7);
            UserGroupStatusList.Add(UserGroupStatus8);
            UserGroupStatusList.Add(UserGroupStatus9);
            UserGroupStatusList.Add(UserGroupStatus10);

            UserGroupStatusDictionary.Add(UserGroupStatus1.Id, UserGroupStatus1);
            UserGroupStatusDictionary.Add(UserGroupStatus2.Id, UserGroupStatus2);
            UserGroupStatusDictionary.Add(UserGroupStatus3.Id, UserGroupStatus3);
            UserGroupStatusDictionary.Add(UserGroupStatus4.Id, UserGroupStatus4);
            UserGroupStatusDictionary.Add(UserGroupStatus5.Id, UserGroupStatus5);
            UserGroupStatusDictionary.Add(UserGroupStatus6.Id, UserGroupStatus6);
            UserGroupStatusDictionary.Add(UserGroupStatus7.Id, UserGroupStatus7);
            UserGroupStatusDictionary.Add(UserGroupStatus8.Id, UserGroupStatus8);
            UserGroupStatusDictionary.Add(UserGroupStatus9.Id, UserGroupStatus9);
            UserGroupStatusDictionary.Add(UserGroupStatus10.Id, UserGroupStatus10);

        }
    }
}

