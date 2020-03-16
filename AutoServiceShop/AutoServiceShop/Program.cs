<<<<<<< Updated upstream
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Presentation.service.Account;
using AutoServiceShop.Data.Common;
using System.Reflection;
=======
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
>>>>>>> Stashed changes

namespace AutoServiceShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
<<<<<<< Updated upstream
            AccountParam testParam = new AccountParam
            {
                FirstName = "Lubo",
                Surname = "Tapak",
                LastName = "Tapak",
                Type = "Idiot",
                Code = "IDIOT",
                Description = "Well, He is an idiot",
                Name = "idiota",
                Id = 3218985,
                AccountStatusId = 1,
                UserId = 11
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

            ApiResponse deleteItem = testService.DeleteById(2);

            Console.WriteLine(deleteItem.text);

            Console.WriteLine("_______________________________________________");

            Console.WriteLine("Finding Name: Gosho in accounts");

            ApiResponse findByFieldName = testService.FindByField("FirstName", "Gosho");

            Console.WriteLine(findByFieldName.text);

            Console.WriteLine("_______________________________________________");

            Console.WriteLine("Finding Lubo");

            ApiResponse findById = testService.FindByPK(testParam.Id);

            Console.WriteLine(findById.text);

            Console.WriteLine("_______________________________________________");

            Console.ReadLine();

            Assembly executing = Assembly.GetExecutingAssembly();

            // Array to store types of the assembly 
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                // Display each type 
                Console.WriteLine("Class : {0}", item.Name);

                // Array to store methods 
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    // Display each method 
                    Console.WriteLine("--> Method : {0}", method.Name);

                    // Array to store parameters 
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        // Display each parameter 
                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }

                PropertyInfo[] properties = item.GetProperties();
=======
            CreateHostBuilder(args).Build().Run();
        }
>>>>>>> Stashed changes

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

<<<<<<< Updated upstream
                    
                }
            }
            Console.ReadLine();
        }
=======
>>>>>>> Stashed changes
    }
}
