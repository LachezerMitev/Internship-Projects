using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Make
{
    class MakeStorage
    {
        public static List<Data.Entity.Make> MakeList = new List<Data.Entity.Make>();
        public static Dictionary<long, Data.Entity.Make> MakeDictionary = new Dictionary<long, Data.Entity.Make>();

        static MakeStorage()
        {
            Data.Entity.Make Make1 = new Data.Entity.Make
            {

            };

            Data.Entity.Make Make2 = new Data.Entity.Make
            {

            };

            Data.Entity.Make Make3 = new Data.Entity.Make
            {

            };
            Data.Entity.Make Make4 = new Data.Entity.Make
            {

            };
            Data.Entity.Make Make5 = new Data.Entity.Make
            {

            };
            Data.Entity.Make Make6 = new Data.Entity.Make
            {

            };
            Data.Entity.Make Make7 = new Data.Entity.Make
            {

            };
            Data.Entity.Make Make8 = new Data.Entity.Make
            {

            };
            Data.Entity.Make Make9 = new Data.Entity.Make
            {

            };
            Data.Entity.Make Make10 = new Data.Entity.Make
            {

            };

            MakeList.Add(Make1);
            MakeList.Add(Make2);
            MakeList.Add(Make3);
            MakeList.Add(Make4);
            MakeList.Add(Make5);
            MakeList.Add(Make6);
            MakeList.Add(Make7);
            MakeList.Add(Make8);
            MakeList.Add(Make9);
            MakeList.Add(Make10);

            MakeDictionary.Add(Make1.Id, Make1);
            MakeDictionary.Add(Make2.Id, Make2);
            MakeDictionary.Add(Make3.Id, Make3);
            MakeDictionary.Add(Make4.Id, Make4);
            MakeDictionary.Add(Make5.Id, Make5);
            MakeDictionary.Add(Make6.Id, Make6);
            MakeDictionary.Add(Make7.Id, Make7);
            MakeDictionary.Add(Make8.Id, Make8);
            MakeDictionary.Add(Make9.Id, Make9);
            MakeDictionary.Add(Make10.Id, Make10);

        }
    }
}
