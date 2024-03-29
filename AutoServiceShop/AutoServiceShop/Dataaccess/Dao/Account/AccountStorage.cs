﻿using AutoServiceShop.Dataaccess.Dao.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;

namespace AutoServiceShop.Dataaccess.Dao.Account
{
    class AccountStorage
    {

        static IAccountStatusDao AccountStatusDao = new AccountStatusDao();
        static IUserDao UserDao = new UserDao();

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
                Id = 1,
                AccountStatus = AccountStatusDao.Find(1),
                User = UserDao.Find(11)
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
                Id = 2,
                AccountStatus = AccountStatusDao.Find(2),
                User = UserDao.Find(21)
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
                Id = 3,
                AccountStatus = AccountStatusDao.Find(3),
                User = UserDao.Find(31)
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
                Id = 4,
                AccountStatus = AccountStatusDao.Find(4),
                User = UserDao.Find(41)
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
                Id = 5,
                AccountStatus = AccountStatusDao.Find(5),
                User = UserDao.Find(51)
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
                Id = 6,
                AccountStatus = AccountStatusDao.Find(6),
                User = UserDao.Find(61)
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
                Id = 7,
                AccountStatus = AccountStatusDao.Find(7),
                User = UserDao.Find(71)
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
                Id = 8,
                AccountStatus = AccountStatusDao.Find(8),
                User = UserDao.Find(81)
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
                Id = 9,
                AccountStatus = AccountStatusDao.Find(9),
                User = UserDao.Find(91)
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
                Id = 10,
                AccountStatus = AccountStatusDao.Find(10),
                User = UserDao.Find(101)
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
