using Autofac;
using AutoServiceShop.Business.Processor.Account;
using AutoServiceShop.Business.Processor.AccountStatus;
using AutoServiceShop.Business.Processor.AutoPart;
using AutoServiceShop.Business.Processor.AutoPartStatus;
using AutoServiceShop.Business.Processor.CheckUp;
using AutoServiceShop.Business.Processor.CheckUpStatus;
using AutoServiceShop.Business.Processor.Contract;
using AutoServiceShop.Business.Processor.ContractStatus;
using AutoServiceShop.Business.Processor.ContractType;
using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Business.Processor.Converter.AccountStatus;
using AutoServiceShop.Business.Processor.Converter.AutoPart;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;
using AutoServiceShop.Business.Processor.Converter.CheckUp;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.Contract;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using AutoServiceShop.Business.Processor.Converter.ContractType;
using AutoServiceShop.Business.Processor.Converter.Customer;
using AutoServiceShop.Business.Processor.Converter.CustomerStatus;
using AutoServiceShop.Business.Processor.Converter.Employee;
using AutoServiceShop.Business.Processor.Converter.EmployeeStatus;
using AutoServiceShop.Business.Processor.Converter.Issue;
using AutoServiceShop.Business.Processor.Converter.Make;
using AutoServiceShop.Business.Processor.Converter.Model;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;
using AutoServiceShop.Business.Processor.Converter.UserUserGroup;
using AutoServiceShop.Business.Processor.Converter.Vehicle;
using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;
using AutoServiceShop.Business.Processor.Converter.VehicleStatus;
using AutoServiceShop.Business.Processor.Customer;
using AutoServiceShop.Business.Processor.CustomerStatus;
using AutoServiceShop.Business.Processor.Employee;
using AutoServiceShop.Business.Processor.EmployeeStatus;
using AutoServiceShop.Business.Processor.Issue;
using AutoServiceShop.Business.Processor.Make;
using AutoServiceShop.Business.Processor.Model;
using AutoServiceShop.Business.Processor.User;
using AutoServiceShop.Business.Processor.UserGroupStatus;
using AutoServiceShop.Business.Processor.UserUserGroup;
using AutoServiceShop.Business.Processor.Vehicle;
using AutoServiceShop.Business.Processor.VehicleMakeModel;
using AutoServiceShop.Business.Processor.VehicleStatus;
using AutoServiceShop.Dataaccess.Dao.Account;
using AutoServiceShop.Dataaccess.Dao.AccountStatus;
using AutoServiceShop.Dataaccess.Dao.AutoPart;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;
using AutoServiceShop.Dataaccess.Dao.CheckUp;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;
using AutoServiceShop.Dataaccess.Dao.Contract;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using AutoServiceShop.Dataaccess.Dao.ContractType;
using AutoServiceShop.Dataaccess.Dao.Customer;
using AutoServiceShop.Dataaccess.Dao.CustomerStatus;
using AutoServiceShop.Dataaccess.Dao.Employee;
using AutoServiceShop.Dataaccess.Dao.EmployeeStatus;
using AutoServiceShop.Dataaccess.Dao.Issue;
using AutoServiceShop.Dataaccess.Dao.Make;
using AutoServiceShop.Dataaccess.Dao.Model;
using AutoServiceShop.Dataaccess.Dao.User;
using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;
using AutoServiceShop.Dataaccess.Dao.UserUserGroup;
using AutoServiceShop.Dataaccess.Dao.Vehicle;
using AutoServiceShop.Dataaccess.Dao.VehicleMakeModel;
using AutoServiceShop.Dataaccess.Dao.VehicleStatus;
using AutoServiceShop.Presentation.service.Account;
using AutoServiceShop.Presentation.service.AccountStatus;
using AutoServiceShop.Presentation.service.AutoPart;
using AutoServiceShop.Presentation.service.AutoPartStatus;
using AutoServiceShop.Presentation.service.CheckUp;
using AutoServiceShop.Presentation.service.CheckUpStatus;
using AutoServiceShop.Presentation.service.Contract;
using AutoServiceShop.Presentation.service.ContractStatus;
using AutoServiceShop.Presentation.service.ContractType;
using AutoServiceShop.Presentation.service.Customer;
using AutoServiceShop.Presentation.service.CustomerStatus;
using AutoServiceShop.Presentation.service.Employee;
using AutoServiceShop.Presentation.service.EmployeeStatus;
using AutoServiceShop.Presentation.service.Issue;
using AutoServiceShop.Presentation.service.Make;
using AutoServiceShop.Presentation.service.Model;
using AutoServiceShop.Presentation.service.User;
using AutoServiceShop.Presentation.service.UserGroupStatus;
using AutoServiceShop.Presentation.service.UserUserGroup;
using AutoServiceShop.Presentation.service.Vehicle;
using AutoServiceShop.Presentation.service.VehicleMakeModel;
using AutoServiceShop.Presentation.service.VehicleStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop
{
    class ProgramFactory
    {
        public static T ResolveSpecific<T>(IContainer container)
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<T>();

                return service;
            } 
        }


        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<AccountService>().As<IAccountService>().PropertiesAutowired();
            builder.RegisterType<AccountStatusService>().As<IAccountStatusService>().PropertiesAutowired();
            builder.RegisterType<AutoPartService>().As<IAutoPartService>().PropertiesAutowired();
            builder.RegisterType<AutoPartStatusService>().As<IAutoPartStatusService>().PropertiesAutowired();
            builder.RegisterType<CheckUpService>().As<ICheckUpService>().PropertiesAutowired();
            builder.RegisterType<CheckUpStatusService>().As<ICheckUpStatusService>().PropertiesAutowired();
            builder.RegisterType<ContractService>().As<IContractService>().PropertiesAutowired();
            builder.RegisterType<ContractStatusService>().As<IContractStatusService>().PropertiesAutowired();
            builder.RegisterType<ContractTypeService>().As<IContractTypeService>().PropertiesAutowired();
            builder.RegisterType<CustomerService>().As<ICustomerService>().PropertiesAutowired();
            builder.RegisterType<CustomerStatusService>().As<ICustomerStatusService>().PropertiesAutowired();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>().PropertiesAutowired();
            builder.RegisterType<EmployeeStatusService>().As<IEmployeeStatusService>().PropertiesAutowired();
            builder.RegisterType<IssueService>().As<IIssueService>().PropertiesAutowired();
            builder.RegisterType<MakeService>().As<IMakeService>().PropertiesAutowired();
            builder.RegisterType<ModelService>().As<IModelService>().PropertiesAutowired();
            builder.RegisterType<UserService>().As<IUserService>().PropertiesAutowired();
            builder.RegisterType<UserGroupStatusService>().As<IUserGroupStatusService>().PropertiesAutowired();
            builder.RegisterType<UserUserGroupService>().As<IUserUserGroupService>().PropertiesAutowired();
            builder.RegisterType<VehicleService>().As<IVehicleService>().PropertiesAutowired();
            builder.RegisterType<VehicleMakeModelService>().As<IVehicleMakeModelService>().PropertiesAutowired();
            builder.RegisterType<VehicleStatusService>().As<IVehicleStatusService>().PropertiesAutowired();

            //////////////////////////////////    Processor    /////////////////////////////////
            builder.RegisterType<AccountProcessor>().As<IAccountProcessor>().PropertiesAutowired();
            builder.RegisterType<AccountStatusProcessor>().As<IAccountStatusProcessor>().PropertiesAutowired();
            builder.RegisterType<AutoPartProcessor>().As<IAutoPartProcessor>().PropertiesAutowired();
            builder.RegisterType<AutoPartStatusProcessor>().As<IAutoPartStatusProcessor>().PropertiesAutowired();
            builder.RegisterType<CheckUpProcessor>().As<ICheckUpProcessor>().PropertiesAutowired();
            builder.RegisterType<CheckUpStatusProcessor>().As<ICheckUpStatusProcessor>().PropertiesAutowired();
            builder.RegisterType<ContractProcessor>().As<IContractProcessor>().PropertiesAutowired();
            builder.RegisterType<ContractStatusProcessor>().As<IContractStatusProcessor>().PropertiesAutowired();
            builder.RegisterType<ContractTypeProcessor>().As<IContractTypeProcessor>().PropertiesAutowired();
            builder.RegisterType<CustomerProcessor>().As<ICustomerProcessor>().PropertiesAutowired();
            builder.RegisterType<CustomerStatusProcessor>().As<ICustomerStatusProcessor>().PropertiesAutowired();
            builder.RegisterType<EmployeeProcessor>().As<IEmployeeProcessor>().PropertiesAutowired();
            builder.RegisterType<EmployeeStatusProcessor>().As<IEmployeeStatusProcessor>().PropertiesAutowired();
            builder.RegisterType<IssueProcessor>().As<IIssueProcessor>().PropertiesAutowired();
            builder.RegisterType<MakeProcessor>().As<IMakeProcessor>().PropertiesAutowired();
            builder.RegisterType<ModelProcessor>().As<IModelProcessor>().PropertiesAutowired();
            builder.RegisterType<UserProcessor>().As<IUserProcessor>().PropertiesAutowired();
            builder.RegisterType<UserGroupStatusProcessor>().As<IUserGroupStatusProcessor>().PropertiesAutowired();
            builder.RegisterType<UserUserGroupProcessor>().As<IUserUserGroupProcessor>().PropertiesAutowired();
            builder.RegisterType<VehicleProcessor>().As<IVehicleProcessor>().PropertiesAutowired();
            builder.RegisterType<VehicleMakeModelProcessor>().As<IVehicleMakeModelProcessor>().PropertiesAutowired();
            builder.RegisterType<VehicleStatusProcessor>().As<IVehicleStatusProcessor>().PropertiesAutowired();


            //////////////////////////////////    DAO    /////////////////////////////////
            builder.RegisterType<AccountDao>().As<IAccountDao>().PropertiesAutowired();
            builder.RegisterType<AccountStatusDao>().As<IAccountStatusDao>().PropertiesAutowired();
            builder.RegisterType<AutoPartDao>().As<IAutoPartDao>().PropertiesAutowired();
            builder.RegisterType<AutoPartStatusDao>().As<IAutoPartStatusDao>().PropertiesAutowired();
            builder.RegisterType<CheckUpDao>().As<ICheckUpDao>().PropertiesAutowired();
            builder.RegisterType<CheckUpStatusDao>().As<ICheckUpStatusDao>().PropertiesAutowired();
            builder.RegisterType<ContractDao>().As<IContractDao>().PropertiesAutowired();
            builder.RegisterType<ContractStatusDao>().As<IContractStatusDao>().PropertiesAutowired();
            builder.RegisterType<ContractTypeDao>().As<IContractTypeDao>().PropertiesAutowired();
            builder.RegisterType<CustomerDao>().As<ICustomerDao>().PropertiesAutowired();
            builder.RegisterType<CustomerStatusDao>().As<ICustomerStatusDao>().PropertiesAutowired();
            builder.RegisterType<EmployeeDao>().As<IEmployeeDao>().PropertiesAutowired();
            builder.RegisterType<EmployeeStatusDao>().As<IEmployeeStatusDao>().PropertiesAutowired();
            builder.RegisterType<IssueDao>().As<IIssueDao>().PropertiesAutowired();
            builder.RegisterType<MakeDao>().As<IMakeDao>().PropertiesAutowired();
            builder.RegisterType<ModelDao>().As<IModelDao>().PropertiesAutowired();
            builder.RegisterType<UserDao>().As<IUserDao>().PropertiesAutowired();
            builder.RegisterType<UserGroupStatusDao>().As<IUserGroupStatusDao>().PropertiesAutowired();
            builder.RegisterType<UserUserGroupDao>().As<IUserUserGroupDao>().PropertiesAutowired();
            builder.RegisterType<VehicleDao>().As<IVehicleDao>().PropertiesAutowired();
            builder.RegisterType<VehicleMakeModelDao>().As<IVehicleMakeModelDao>().PropertiesAutowired();
            builder.RegisterType<VehicleStatusDao>().As<IVehicleStatusDao>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<AccountParamConverter>().As<IAccountParamConverter>().PropertiesAutowired();
            builder.RegisterType<AccountStatusParamConvert>().As<IAccountStatusParamConverter>().PropertiesAutowired();
            builder.RegisterType<AutoPartParamConverter>().As<IAutoPartParamConverter>().PropertiesAutowired();
            builder.RegisterType<AutoPartStatusParamConverter>().As<IAutoPartStatusParamConverter>().PropertiesAutowired();
            builder.RegisterType<CheckUpParamConverter>().As<ICheckUpParamConverter>().PropertiesAutowired();
            builder.RegisterType<CheckUpStatusParamConverter>().As<ICheckUpStatusParamConverter>().PropertiesAutowired();
            builder.RegisterType<ContractParamConverter>().As<IContractParamconverter>().PropertiesAutowired();
            builder.RegisterType<ContractStatusParamConverter>().As<IContractStatusParamConverter>().PropertiesAutowired();
            builder.RegisterType<ContractTypeParamConverter>().As<IContractTypeParamConverter>().PropertiesAutowired();
            builder.RegisterType<CustomerParamConverter>().As<ICustomerParamConverter>().PropertiesAutowired();
            builder.RegisterType<CustomerStatusParamConverter>().As<ICustomerStatusParamConverter>().PropertiesAutowired();
            builder.RegisterType<EmployeeParamConverter>().As<IEmployeeParamConverter>().PropertiesAutowired();
            builder.RegisterType<EmployeeStatusParamConverter>().As<IEmployeeStatusParamConverter>().PropertiesAutowired();
            builder.RegisterType<IssueParamConverter>().As<IIssueParamConverter>().PropertiesAutowired();
            builder.RegisterType<MakeParamConverter>().As<IMakeParamConverter>().PropertiesAutowired();
            builder.RegisterType<ModelParamConverter>().As<IModelParamConverter>().PropertiesAutowired();
            builder.RegisterType<UserParamConverter>().As<IUserParamConverter>().PropertiesAutowired();
            builder.RegisterType<UserGroupStatusParamConverter>().As<IUserGroupStatusParamConverter>().PropertiesAutowired();
            builder.RegisterType<UserUserGroupParamConverter>().As<IUserUserGroupParamConverter>().PropertiesAutowired();
            builder.RegisterType<VehicleParamConverter>().As<IVehicleParamConverter>().PropertiesAutowired();
            builder.RegisterType<VehicleMakeModelParamConverter>().As<IVehicleMakeModelParamConverter>().PropertiesAutowired();
            builder.RegisterType<VehicleStatusParamConverter>().As<IVehicleStatusParamConverter>().PropertiesAutowired();

            //////////////////////////////////    ResultConverter    /////////////////////////////////
            builder.RegisterType<AccountResultConverter>().As<IAccountResultConverter>();
            builder.RegisterType<AccountStatusResultConvert>().As<IAccountStatusResultConvert>();
            builder.RegisterType<AutoPartResultConverter>().As<IAutoPartResultConvert>();
            builder.RegisterType<AutoPartStatusResultConverter>().As<IAutoPartStatusResultConverter>();
            builder.RegisterType<CheckUpResultConverter>().As<ICheckUpResultConverter>();
            builder.RegisterType<CheckUpStatusResultConverter>().As<ICheckUpStatusResultConverter>();
            builder.RegisterType<ContractResultConverter>().As<IContractResultConverter>();
            builder.RegisterType<ContractStatusResultConverter>().As<IContractStatusResultConverter>();
            builder.RegisterType<ContractTypeResultConverter>().As<IContractTypeResultConverter>();
            builder.RegisterType<CustomerResultConverter>().As<ICustomerResultConverter>();
            builder.RegisterType<CustomerStatusResultConverter>().As<ICustomerStatusResultConverter>();
            builder.RegisterType<EmployeeResultConverter>().As<IEmployeeResultConverter>();
            builder.RegisterType<EmployeeStatusResultConverter>().As<IEmployeeStatusResultConverter>();
            builder.RegisterType<IssueResultConverter>().As<IIssueResultConverter>();
            builder.RegisterType<MakeResultConverter>().As<IMakeResultConverter>();
            builder.RegisterType<ModelResultConverrter>().As<IModelResultConverter>();
            builder.RegisterType<UserResultConverter>().As<IUserResultConverter>();
            builder.RegisterType<UserGroupStatusResultConverter>().As<IUserGroupStatusResultConverter>();
            builder.RegisterType<UserUserGroupResultConverter>().As<IUserUserGroupResultConverter>();
            builder.RegisterType<VehicleResultConverter>().As<IVehicleResultConverter>();
            builder.RegisterType<VehicleMakeModelResultConverter>().As<IVehicleMakeModelResultConverter>();
            builder.RegisterType<VehicleStatusResultConverter>().As<IVehicleStatusResultConverter>();

            //////////////////////////////////    E N D    /////////////////////////////////


            var container = builder.Build();

            return container;
        }
    }
}
