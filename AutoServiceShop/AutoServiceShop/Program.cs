using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Presentation.service.Account;
using AutoServiceShop.Data.Common;
using System.Reflection;
<<<<<<< Updated upstream
=======
using AutoServiceShop.Presentation.service.AccountStatus;
using AutoServiceShop.Presentation.service.AutoPart;
using AutoServiceShop.Presentation.service.User;
using AutoServiceShop.Business.Processor.Account;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.FactoryDI.Account;
>>>>>>> Stashed changes

namespace AutoServiceShop
{
    class Program
    {
        static void Main(string[] args)
        {

            //IUserService testService = ProgramFactory.ResolveSpecific<IUserService>(ProgramFactory.BuildContainer());

            //Console.WriteLine(testService.FindByField("Username", "joro").text);

            //UserParam testUser = new UserParam
            //{
            //    Id = 2,
            //    Username = "Georgi",
            //    Password = "Deeba_toz_EF"
            //};

            //Console.WriteLine(testService.Create(testUser).text);

            //Console.WriteLine(testService.ListAll().text);


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
                UserId = 11,
                AccountTypeId = 1
            };

            AccountService testService = new AccountService();

            Console.WriteLine("Adding an Account");

            ApiResponse response = testService.Create(testParam);

            Console.WriteLine(response.text);

            //Console.WriteLine("_______________________________________________");
            //Console.WriteLine("Listing all accounts");

            //ApiResponse fbf = testService.FindByField("FirstName", "Lubo");

            //ApiResponse listall = testService.ListAll();

            //Console.WriteLine(listall.text);

            Console.WriteLine("_______________________________________________");
            Console.WriteLine("Removing an account");

            ApiResponse deleteItem = testService.DeleteById(3218985);

            Console.WriteLine(deleteItem.text);

            //Console.WriteLine("_______________________________________________");

            //Console.WriteLine("Finding Name: Gosho in accounts");

            //ApiResponse findByFieldName = testService.FindByField("FirstName", "Gosho");

            //Console.WriteLine(findByFieldName.text);

<<<<<<< Updated upstream
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
            //Console.WriteLine("_______________________________________________");

            //Console.WriteLine("Finding Lubo");

            //ApiResponse findById = testService.FindByPK(testParam.Id);

            //Console.WriteLine(findById.text);

            //Console.WriteLine("_______________________________________________");


            //Console.WriteLine("Updating Lubo");

            //testParam.FirstName = "Lubo";
            //testParam.Surname = "Tapak";
            //testParam.LastName = "Tapak";
            //testParam.Type = "BIG Idiot";
            //testParam.Code = "ORTA";
            //testParam.Description = "Well, He is an even bigger idiot";
            //testParam.Name = "idiota";
            //testParam.Id = 1;
            //testParam.AccountStatusId = 1;
            //testParam.UserId = 11;

            //ApiResponse updateLubo = testService.Update(1, testParam);

            //Console.WriteLine(updateLubo.text);

            //Console.WriteLine("_______________________________________________");

>>>>>>> Stashed changes
            Console.ReadLine();
        }
    }
}
