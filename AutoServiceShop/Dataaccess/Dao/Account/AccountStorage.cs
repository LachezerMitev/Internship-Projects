using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Account
{
    class AccountStorage
    {

        public static List<Data.Entity.Account> AccountList = new List<Data.Entity.Account>();
        public static Dictionary<long, Data.Entity.Account> AccountDictionary= new Dictionary<long, Data.Entity.Account>();

        static AccountStorage()
        {
            Data.Entity.Account account1 = new Data.Entity.Account
            {
                FirstName = "Gosho",
                Surname = "Ivanov",
                LastName = "Golemiq",
                Type = "WorEmployeeker",
                Code = "ORTA",
                Description = "Well, He works...... stuff..... idk",
                Name = "Georgi",
                Id = 12352456
            };

            Data.Entity.Account account2 = new Data.Entity.Account
            {
                FirstName = "Ivan",
                Surname = "Georgiev",
                LastName = "Shotlekov",
                Type = "Employee",
                Code = "PVRT",
                Description = "Engine specialist",
                Name = "Ivan",
                Id = 14573574
            };

            Data.Entity.Account account3 = new Data.Entity.Account
            {
                FirstName = "Petar",
                Surname = "Petrov",
                LastName = "Petrov",
                Type = "Customer",
                Code = "KVPK",
                Description = "Car",
                Name = "Petar",
                Id = 0157617
            };
            Data.Entity.Account account4 = new Data.Entity.Account
            {
                FirstName = "Dimitar",
                Surname = "Latunov",
                LastName = "Mitev",
                Type = "Customer",
                Code = "KLMN",
                Description = "Motorcycle",
                Name = "Mitko",
                Id = 0128674
            };
            Data.Entity.Account account5 = new Data.Entity.Account
            {
                FirstName = "Mitko",
                Surname = "Borislav",
                LastName = "Petrov",
                Type = "Admin",
                Code = "LKVF",
                Description = "System Administrator",
                Name = "Mitko",
                Id = 254685
            };
            Data.Entity.Account account6 = new Data.Entity.Account
            {
                FirstName = "Joro",
                Surname = "Spasimirov",
                LastName = "Angelov",
                Type = "Intern",
                Code = "OSDA",
                Description = "Suspension intern",
                Name = "Joro",
                Id = 348652
            };
            Data.Entity.Account account7 = new Data.Entity.Account
            {
                FirstName = "Georgi",
                Surname = "Ivanov",
                LastName = "Peshev",
                Type = "Intern",
                Code = "ARTI",
                Description = "General intern",
                Name = "Joro",
                Id = 348952
            };
            Data.Entity.Account account8 = new Data.Entity.Account
            {
                FirstName = "Georgi",
                Surname = "Penev",
                LastName = "Tenev",
                Type = "Employee",
                Code = "PROS",
                Description = "Senior Suspension specialist",
                Name = "Gergi",
                Id = 145326
            };
            Data.Entity.Account account9 = new Data.Entity.Account
            {
                FirstName = "Stanislav",
                Surname = "Tenev",
                LastName = "Proiski",
                Type = "Employee",
                Code = "MAKF",
                Description = "Electrical specialist",
                Name = "Stanislav",
                Id = 12352456
            };
            Data.Entity.Account account10 = new Data.Entity.Account
            {
                FirstName = "Teodor",
                Surname = "Spasov",
                LastName = "Georgiev",
                Type = "Customer",
                Code = "IFHE",
                Description = "Car",
                Name = "Tedo",
                Id = 145367
            };

            AccountList.Add(account1);
            AccountList.Add(account2);
            AccountList.Add(account3);
            AccountList.Add(account4);
            AccountList.Add(account5);
            AccountList.Add(account6);
            AccountList.Add(account7);
            AccountList.Add(account8);
            AccountList.Add(account9);
            AccountList.Add(account10);

            AccountDictionary.Add(account1.Id, account1);
            AccountDictionary.Add(account2.Id, account2);
            AccountDictionary.Add(account3.Id, account3);
            AccountDictionary.Add(account4.Id, account4);
            AccountDictionary.Add(account5.Id, account5);
            AccountDictionary.Add(account6.Id, account6);
            AccountDictionary.Add(account7.Id, account7);
            AccountDictionary.Add(account8.Id, account8);
            AccountDictionary.Add(account9.Id, account9);
            AccountDictionary.Add(account10.Id, account10);

        }
    }
}
