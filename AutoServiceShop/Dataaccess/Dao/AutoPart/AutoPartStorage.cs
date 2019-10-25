using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.AutoPart
{
    class AutoPartStorage
    {
        public static List<Data.Entity.AutoPart> AutoPartList = new List<Data.Entity.AutoPart>();
        public static Dictionary<long, Data.Entity.AutoPart> AutoPartDictionary = new Dictionary<long, Data.Entity.AutoPart>();

        static AutoPartStorage()
        {
            Data.Entity.AutoPart AutoPart1 = new Data.Entity.AutoPart
            {

            };

            Data.Entity.AutoPart AutoPart2 = new Data.Entity.AutoPart
            {
                
            };

            Data.Entity.AutoPart AutoPart3 = new Data.Entity.AutoPart
            {
               
            };
            Data.Entity.AutoPart AutoPart4 = new Data.Entity.AutoPart
            {
                
            };
            Data.Entity.AutoPart AutoPart5 = new Data.Entity.AutoPart
            {
                
            };
            Data.Entity.AutoPart AutoPart6 = new Data.Entity.AutoPart
            {
                
            };
            Data.Entity.AutoPart AutoPart7 = new Data.Entity.AutoPart
            {
                
            };
            Data.Entity.AutoPart AutoPart8 = new Data.Entity.AutoPart
            {
                
            };
            Data.Entity.AutoPart AutoPart9 = new Data.Entity.AutoPart
            {
                
            };
            Data.Entity.AutoPart AutoPart10 = new Data.Entity.AutoPart
            {
                
            };

            AutoPartList.Add(AutoPart1);
            AutoPartList.Add(AutoPart2);
            AutoPartList.Add(AutoPart3);
            AutoPartList.Add(AutoPart4);
            AutoPartList.Add(AutoPart5);
            AutoPartList.Add(AutoPart6);
            AutoPartList.Add(AutoPart7);
            AutoPartList.Add(AutoPart8);
            AutoPartList.Add(AutoPart9);
            AutoPartList.Add(AutoPart10);

            AutoPartDictionary.Add(AutoPart1.Id, AutoPart1);
            AutoPartDictionary.Add(AutoPart2.Id, AutoPart2);
            AutoPartDictionary.Add(AutoPart3.Id, AutoPart3);
            AutoPartDictionary.Add(AutoPart4.Id, AutoPart4);
            AutoPartDictionary.Add(AutoPart5.Id, AutoPart5);
            AutoPartDictionary.Add(AutoPart6.Id, AutoPart6);
            AutoPartDictionary.Add(AutoPart7.Id, AutoPart7);
            AutoPartDictionary.Add(AutoPart8.Id, AutoPart8);
            AutoPartDictionary.Add(AutoPart9.Id, AutoPart9);
            AutoPartDictionary.Add(AutoPart10.Id, AutoPart10);

        }
    }
}
