using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.CustomerStatus
{
    class CustomerStatusStorage
    {
        public static List<Data.Entity.CustomerStatus> CustomerStatusList = new List<Data.Entity.CustomerStatus>();
        public static Dictionary<long, Data.Entity.CustomerStatus> CustomerStatusDictionary = new Dictionary<long, Data.Entity.CustomerStatus>();

        static CustomerStatusStorage()
        {
            Data.Entity.CustomerStatus CustomerStatus1 = new Data.Entity.CustomerStatus
            {

            };

            Data.Entity.CustomerStatus CustomerStatus2 = new Data.Entity.CustomerStatus
            {

            };

            Data.Entity.CustomerStatus CustomerStatus3 = new Data.Entity.CustomerStatus
            {

            };
            Data.Entity.CustomerStatus CustomerStatus4 = new Data.Entity.CustomerStatus
            {

            };
            Data.Entity.CustomerStatus CustomerStatus5 = new Data.Entity.CustomerStatus
            {

            };
            Data.Entity.CustomerStatus CustomerStatus6 = new Data.Entity.CustomerStatus
            {

            };
            Data.Entity.CustomerStatus CustomerStatus7 = new Data.Entity.CustomerStatus
            {

            };
            Data.Entity.CustomerStatus CustomerStatus8 = new Data.Entity.CustomerStatus
            {

            };
            Data.Entity.CustomerStatus CustomerStatus9 = new Data.Entity.CustomerStatus
            {

            };
            Data.Entity.CustomerStatus CustomerStatus10 = new Data.Entity.CustomerStatus
            {

            };

            CustomerStatusList.Add(CustomerStatus1);
            CustomerStatusList.Add(CustomerStatus2);
            CustomerStatusList.Add(CustomerStatus3);
            CustomerStatusList.Add(CustomerStatus4);
            CustomerStatusList.Add(CustomerStatus5);
            CustomerStatusList.Add(CustomerStatus6);
            CustomerStatusList.Add(CustomerStatus7);
            CustomerStatusList.Add(CustomerStatus8);
            CustomerStatusList.Add(CustomerStatus9);
            CustomerStatusList.Add(CustomerStatus10);

            CustomerStatusDictionary.Add(CustomerStatus1.Id, CustomerStatus1);
            CustomerStatusDictionary.Add(CustomerStatus2.Id, CustomerStatus2);
            CustomerStatusDictionary.Add(CustomerStatus3.Id, CustomerStatus3);
            CustomerStatusDictionary.Add(CustomerStatus4.Id, CustomerStatus4);
            CustomerStatusDictionary.Add(CustomerStatus5.Id, CustomerStatus5);
            CustomerStatusDictionary.Add(CustomerStatus6.Id, CustomerStatus6);
            CustomerStatusDictionary.Add(CustomerStatus7.Id, CustomerStatus7);
            CustomerStatusDictionary.Add(CustomerStatus8.Id, CustomerStatus8);
            CustomerStatusDictionary.Add(CustomerStatus9.Id, CustomerStatus9);
            CustomerStatusDictionary.Add(CustomerStatus10.Id, CustomerStatus10);

        }
    }
}
