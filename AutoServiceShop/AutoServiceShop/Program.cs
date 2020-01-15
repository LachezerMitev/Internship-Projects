using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Business.Processor.Converter.AccountStatus;
using AutoServiceShop.Business.Processor.Converter.AccountType;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Data.Common;
<<<<<<< Updated upstream
using System.Reflection;
=======
using AutoServiceShop.Data.Entity;
using AutoServiceShop.FactoryDI;
using AutoServiceShop.FactoryDI.Account;
using AutoServiceShop.Presentation.JsonConverter;
using AutoServiceShop.Presentation.service.Account;
using AutoServiceShop.Presentation.service.AccountStatus;
using AutoServiceShop.Presentation.service.AccountType;
using AutoServiceShop.Presentation.service.AutoPart;
using AutoServiceShop.Presentation.service.CheckUp;
using AutoServiceShop.Presentation.service.User;
using AutoServiceShop.Presentation.service.Vehicle;
using System;
>>>>>>> Stashed changes

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
                AccountStatusId = 1,
<<<<<<< Updated upstream
                UserId = 11
=======
                UserId = 1,
                AccountTypeId = 1
>>>>>>> Stashed changes
            };

            IUserService testService = UserFactory.ResolveEF();

<<<<<<< Updated upstream
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
=======
            Console.WriteLine(testService.DeleteById(1).text);

            Console.WriteLine("_______________________________________________");

>>>>>>> Stashed changes
            Console.ReadLine();
        }
    }
}
