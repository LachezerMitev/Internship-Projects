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

            AccountDao accountDao = new AccountDao();
            AccountParamConverter accountParamConverter = new AccountParamConverter();
            AccountResultConverter accountResultConverter = new AccountResultConverter();
            AccountProcessor accountProcessor = new AccountProcessor();
            accountProcessor.AccountResultConverter = accountResultConverter;
            accountProcessor.AccountParamConverter = accountParamConverter;
            accountProcessor.AccountDao = accountDao;
            AccountService testService = new AccountService() { AccountProcessor = accountProcessor};


            ApiResponse response = testService.Create(testParam);

            Console.WriteLine(response.text);

            Console.ReadLine();
        }
    }
}
