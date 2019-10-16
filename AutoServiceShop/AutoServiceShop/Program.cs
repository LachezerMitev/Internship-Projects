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

namespace AutoServiceShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Account testccount = new Account
            {
                FirstName = "Gosho",
                Surname = "Ivanov",
                LastName = "Golemiq",
                Type = "Golemiq"
            };

            string output = JsonConvert.SerializeObject(testccount);

            AccountParam testParam = new AccountParam
            {
                jsonString = output
            };

            AccountDao accountDao = new AccountDao();
            AccountParamConverter accountParamConverter = new AccountParamConverter();
            AccountResultConverter accountResultConverter = new AccountResultConverter();
            AccountProcessor accountProcessor = new AccountProcessor();
            accountProcessor.AccountResultConverter = accountResultConverter;
            accountProcessor.AccountParamConverter = accountParamConverter;
            accountProcessor.AccountDao = accountDao;
            AccountService testService = new AccountService();
            testService.AccountProcessor = accountProcessor;
            

            testService.Create(testParam);

            Console.ReadLine();
        }
    }
}
