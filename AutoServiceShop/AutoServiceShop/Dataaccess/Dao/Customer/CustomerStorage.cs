using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Customer
{
    class CustomerStorage
    {
        public static List<Data.Entity.Customer> CustomerList = new List<Data.Entity.Customer>();
        public static Dictionary<long, Data.Entity.Customer> CustomerDictionary = new Dictionary<long, Data.Entity.Customer>();

        static CustomerStorage()
        {
            Data.Entity.Customer Customer1 = new Data.Entity.Customer
            {

            };

            Data.Entity.Customer Customer2 = new Data.Entity.Customer
            {

            };

            Data.Entity.Customer Customer3 = new Data.Entity.Customer
            {

            };
            Data.Entity.Customer Customer4 = new Data.Entity.Customer
            {

            };
            Data.Entity.Customer Customer5 = new Data.Entity.Customer
            {

            };
            Data.Entity.Customer Customer6 = new Data.Entity.Customer
            {

            };
            Data.Entity.Customer Customer7 = new Data.Entity.Customer
            {

            };
            Data.Entity.Customer Customer8 = new Data.Entity.Customer
            {

            };
            Data.Entity.Customer Customer9 = new Data.Entity.Customer
            {

            };
            Data.Entity.Customer Customer10 = new Data.Entity.Customer
            {

            };

            CustomerList.Add(Customer1);
            CustomerList.Add(Customer2);
            CustomerList.Add(Customer3);
            CustomerList.Add(Customer4);
            CustomerList.Add(Customer5);
            CustomerList.Add(Customer6);
            CustomerList.Add(Customer7);
            CustomerList.Add(Customer8);
            CustomerList.Add(Customer9);
            CustomerList.Add(Customer10);

            CustomerDictionary.Add(Customer1.Id, Customer1);
            CustomerDictionary.Add(Customer2.Id, Customer2);
            CustomerDictionary.Add(Customer3.Id, Customer3);
            CustomerDictionary.Add(Customer4.Id, Customer4);
            CustomerDictionary.Add(Customer5.Id, Customer5);
            CustomerDictionary.Add(Customer6.Id, Customer6);
            CustomerDictionary.Add(Customer7.Id, Customer7);
            CustomerDictionary.Add(Customer8.Id, Customer8);
            CustomerDictionary.Add(Customer9.Id, Customer9);
            CustomerDictionary.Add(Customer10.Id, Customer10);

        }
    }
}
