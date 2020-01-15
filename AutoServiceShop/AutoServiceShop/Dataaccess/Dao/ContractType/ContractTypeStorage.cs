using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.ContractType
{
    class ContractTypeStorage
    {
        public static List<Data.Entity.ContractType> ContractTypeList = new List<Data.Entity.ContractType>();
        public static Dictionary<long, Data.Entity.ContractType> ContractTypeDictionary = new Dictionary<long, Data.Entity.ContractType>();

        static ContractTypeStorage()
        {
            Data.Entity.ContractType ContractType1 = new Data.Entity.ContractType
            {

<<<<<<< Updated upstream
            };

            Data.Entity.ContractType ContractType2 = new Data.Entity.ContractType
            {

            };

            Data.Entity.ContractType ContractType3 = new Data.Entity.ContractType
            {

            };
            Data.Entity.ContractType ContractType4 = new Data.Entity.ContractType
            {

            };
            Data.Entity.ContractType ContractType5 = new Data.Entity.ContractType
            {

            };
            Data.Entity.ContractType ContractType6 = new Data.Entity.ContractType
            {

            };
            Data.Entity.ContractType ContractType7 = new Data.Entity.ContractType
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.ContractType>>(json);
        }
>>>>>>> Stashed changes

            };
            Data.Entity.ContractType ContractType8 = new Data.Entity.ContractType
            {

            };
            Data.Entity.ContractType ContractType9 = new Data.Entity.ContractType
            {

            };
            Data.Entity.ContractType ContractType10 = new Data.Entity.ContractType
            {

            };

            ContractTypeList.Add(ContractType1);
            ContractTypeList.Add(ContractType2);
            ContractTypeList.Add(ContractType3);
            ContractTypeList.Add(ContractType4);
            ContractTypeList.Add(ContractType5);
            ContractTypeList.Add(ContractType6);
            ContractTypeList.Add(ContractType7);
            ContractTypeList.Add(ContractType8);
            ContractTypeList.Add(ContractType9);
            ContractTypeList.Add(ContractType10);

            ContractTypeDictionary.Add(ContractType1.Id, ContractType1);
            ContractTypeDictionary.Add(ContractType2.Id, ContractType2);
            ContractTypeDictionary.Add(ContractType3.Id, ContractType3);
            ContractTypeDictionary.Add(ContractType4.Id, ContractType4);
            ContractTypeDictionary.Add(ContractType5.Id, ContractType5);
            ContractTypeDictionary.Add(ContractType6.Id, ContractType6);
            ContractTypeDictionary.Add(ContractType7.Id, ContractType7);
            ContractTypeDictionary.Add(ContractType8.Id, ContractType8);
            ContractTypeDictionary.Add(ContractType9.Id, ContractType9);
            ContractTypeDictionary.Add(ContractType10.Id, ContractType10);

        }
    }
}
