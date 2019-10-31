using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.CheckUp
{
    class CheckUpStorage
    {
        public static List<Data.Entity.CheckUp> CheckUpList = new List<Data.Entity.CheckUp>();
        public static Dictionary<long, Data.Entity.CheckUp> CheckUpDictionary = new Dictionary<long, Data.Entity.CheckUp>();

        static CheckUpStorage()
        {
            Data.Entity.CheckUp CheckUp1 = new Data.Entity.CheckUp
            {

            };

            Data.Entity.CheckUp CheckUp2 = new Data.Entity.CheckUp
            {

            };

            Data.Entity.CheckUp CheckUp3 = new Data.Entity.CheckUp
            {

            };
            Data.Entity.CheckUp CheckUp4 = new Data.Entity.CheckUp
            {

            };
            Data.Entity.CheckUp CheckUp5 = new Data.Entity.CheckUp
            {

            };
            Data.Entity.CheckUp CheckUp6 = new Data.Entity.CheckUp
            {

            };
            Data.Entity.CheckUp CheckUp7 = new Data.Entity.CheckUp
            {

            };
            Data.Entity.CheckUp CheckUp8 = new Data.Entity.CheckUp
            {

            };
            Data.Entity.CheckUp CheckUp9 = new Data.Entity.CheckUp
            {

            };
            Data.Entity.CheckUp CheckUp10 = new Data.Entity.CheckUp
            {

            };

            CheckUpList.Add(CheckUp1);
            CheckUpList.Add(CheckUp2);
            CheckUpList.Add(CheckUp3);
            CheckUpList.Add(CheckUp4);
            CheckUpList.Add(CheckUp5);
            CheckUpList.Add(CheckUp6);
            CheckUpList.Add(CheckUp7);
            CheckUpList.Add(CheckUp8);
            CheckUpList.Add(CheckUp9);
            CheckUpList.Add(CheckUp10);

            CheckUpDictionary.Add(CheckUp1.Id, CheckUp1);
            CheckUpDictionary.Add(CheckUp2.Id, CheckUp2);
            CheckUpDictionary.Add(CheckUp3.Id, CheckUp3);
            CheckUpDictionary.Add(CheckUp4.Id, CheckUp4);
            CheckUpDictionary.Add(CheckUp5.Id, CheckUp5);
            CheckUpDictionary.Add(CheckUp6.Id, CheckUp6);
            CheckUpDictionary.Add(CheckUp7.Id, CheckUp7);
            CheckUpDictionary.Add(CheckUp8.Id, CheckUp8);
            CheckUpDictionary.Add(CheckUp9.Id, CheckUp9);
            CheckUpDictionary.Add(CheckUp10.Id, CheckUp10);

        }
    }
}
