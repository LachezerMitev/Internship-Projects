using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Model
{
    class ModelStorage
    {
        public static List<Data.Entity.Model> ModelList = new List<Data.Entity.Model>();
        public static Dictionary<long, Data.Entity.Model> ModelDictionary = new Dictionary<long, Data.Entity.Model>();

        static ModelStorage()
        {
            Data.Entity.Model Model1 = new Data.Entity.Model
            {

<<<<<<< Updated upstream
            };

            Data.Entity.Model Model2 = new Data.Entity.Model
            {

            };

            Data.Entity.Model Model3 = new Data.Entity.Model
            {

            };
            Data.Entity.Model Model4 = new Data.Entity.Model
            {

            };
            Data.Entity.Model Model5 = new Data.Entity.Model
            {

            };
            Data.Entity.Model Model6 = new Data.Entity.Model
            {

            };
            Data.Entity.Model Model7 = new Data.Entity.Model
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.Model>>(json);
        }
>>>>>>> Stashed changes

            };
            Data.Entity.Model Model8 = new Data.Entity.Model
            {

            };
            Data.Entity.Model Model9 = new Data.Entity.Model
            {

            };
            Data.Entity.Model Model10 = new Data.Entity.Model
            {

            };

            ModelList.Add(Model1);
            ModelList.Add(Model2);
            ModelList.Add(Model3);
            ModelList.Add(Model4);
            ModelList.Add(Model5);
            ModelList.Add(Model6);
            ModelList.Add(Model7);
            ModelList.Add(Model8);
            ModelList.Add(Model9);
            ModelList.Add(Model10);

            ModelDictionary.Add(Model1.Id, Model1);
            ModelDictionary.Add(Model2.Id, Model2);
            ModelDictionary.Add(Model3.Id, Model3);
            ModelDictionary.Add(Model4.Id, Model4);
            ModelDictionary.Add(Model5.Id, Model5);
            ModelDictionary.Add(Model6.Id, Model6);
            ModelDictionary.Add(Model7.Id, Model7);
            ModelDictionary.Add(Model8.Id, Model8);
            ModelDictionary.Add(Model9.Id, Model9);
            ModelDictionary.Add(Model10.Id, Model10);

        }
    }
}
