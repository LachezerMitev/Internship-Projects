﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Presentation.service.Account;
using AutoServiceShop.Data.Common;
using System.Reflection;

namespace AutoServiceShop
{
    class Program
    {
        static void Main(string[] args)
        {
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

                foreach (var property in properties)
                {
                    // Display each method 
                    Console.WriteLine("--> Property : {0}", property.Name);

                    
                }
            }
            Console.ReadLine();
        }
    }
}
