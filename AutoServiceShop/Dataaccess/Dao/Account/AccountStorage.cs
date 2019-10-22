using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Account
{
    class AccountStorage
    {
       
        public static List<Data.Entity.Account> Accounts = new List<Data.Entity.Account>();

        static AccountStorage()
        {
            Data.Entity.Account account1 = new Data.Entity.Account
            {
                FirstName = "Gosho",
                Surname = "Ivanov",
                LastName = "Golemiq",
                Type = "WorEmployeeker",
                Code = 1235486,
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
                Code = 1236584,
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
                Code = 1235751,
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
                Code = 012458,
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
                Code = 254675,
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
                Code = 348567,
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
                Code = 348259,
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
                Code = 126845,
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
                Code = 234157,
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
                Code = 145637,
                Description = "Car",
                Name = "Tedo",
                Id = 145367
            };

            Accounts.Add(account1);
            Accounts.Add(account2);
            Accounts.Add(account3);
            Accounts.Add(account4);
            Accounts.Add(account5);
            Accounts.Add(account6);
            Accounts.Add(account7);
            Accounts.Add(account8);
            Accounts.Add(account9);
            Accounts.Add(account10);
        }
    }
}
