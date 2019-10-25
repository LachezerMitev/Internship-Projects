using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Presentation.service.Account;
using AutoServiceShop.Dataaccess.Dao.Account;
using AutoServiceShop.Business.Processor.Account;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountParam testParam = new AccountParam
            {
                FirstName = "Gosho",
                Surname = "Ivanov",
                LastName = "Golemiq",
                Type = "Rabotnik",
                Code = 1235486,
                Description = "Well, He works...... stuff..... idk",
                Name = "Georgi",
                Id = 12352456
            };

            AccountService testService = new AccountService();

            Console.WriteLine("Adding an Account");

            ApiResponse response = testService.Create(testParam);

            Console.WriteLine(response.text);

            Console.WriteLine("_______________________________________________");
            Console.WriteLine("Listing all accounts");

            ApiResponse listAll = testService.ListAll();

            Console.WriteLine(listAll.text);

            Console.WriteLine("_______________________________________________");
            Console.WriteLine("Removing an account");

            ApiResponse deleteItem = testService.DeleteById(145367);

            Console.WriteLine(deleteItem.text);

            Console.WriteLine("_______________________________________________");

            Console.ReadLine();
        }
    }
}
