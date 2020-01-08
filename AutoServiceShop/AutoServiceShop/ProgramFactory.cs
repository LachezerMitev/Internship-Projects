using Autofac;
using AutoServiceShop.Business.Processor.Account;
using AutoServiceShop.Business.Processor.AccountStatus;
using AutoServiceShop.Business.Processor.AccountType;
using AutoServiceShop.Business.Processor.AutoPart;
using AutoServiceShop.Business.Processor.AutoPartStatus;
using AutoServiceShop.Business.Processor.CheckUp;
using AutoServiceShop.Business.Processor.CheckUpStatus;
using AutoServiceShop.Business.Processor.Contract;
using AutoServiceShop.Business.Processor.ContractStatus;
using AutoServiceShop.Business.Processor.ContractType;
using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Business.Processor.Converter.AccountStatus;
using AutoServiceShop.Business.Processor.Converter.AccountType;
using AutoServiceShop.Business.Processor.Converter.AutoPart;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;
using AutoServiceShop.Business.Processor.Converter.CheckUp;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.Contract;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using AutoServiceShop.Business.Processor.Converter.ContractType;
using AutoServiceShop.Business.Processor.Converter.Issue;
using AutoServiceShop.Business.Processor.Converter.Make;
using AutoServiceShop.Business.Processor.Converter.Model;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;
using AutoServiceShop.Business.Processor.Converter.UserUserGroup;
using AutoServiceShop.Business.Processor.Converter.Vehicle;
using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;
using AutoServiceShop.Business.Processor.Converter.VehicleStatus;
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
using AutoServiceShop.Dataaccess.Dao.AccountType;
using AutoServiceShop.Dataaccess.Dao.AutoPart;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;
using AutoServiceShop.Dataaccess.Dao.CheckUp;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;
using AutoServiceShop.Dataaccess.Dao.Contract;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using AutoServiceShop.Dataaccess.Dao.ContractType;
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
using AutoServiceShop.Presentation.service.AccountType;
using AutoServiceShop.Presentation.service.AutoPart;
using AutoServiceShop.Presentation.service.AutoPartStatus;
using AutoServiceShop.Presentation.service.CheckUp;
using AutoServiceShop.Presentation.service.CheckUpStatus;
using AutoServiceShop.Presentation.service.Common;
using AutoServiceShop.Presentation.service.Contract;
using AutoServiceShop.Presentation.service.ContractStatus;
using AutoServiceShop.Presentation.service.ContractType;
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


        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();


            ///////////////////////////////    S T A R T  D I    //////////////////////////////

            //////////////////////////////////    SERVICES    /////////////////////////////////
            builder.RegisterType<AccountService>().As<IAccountService>().PropertiesAutowired();
            builder.RegisterType<AccountStatusService>().As<IAccountStatusService>().PropertiesAutowired();
            builder.RegisterType<AccountTypeService>().As<IAccountTypeService>().PropertiesAutowired();
            builder.RegisterType<AutoPartService>().As<IAutoPartService>().PropertiesAutowired();
            builder.RegisterType<AutoPartStatusService>().As<IAutoPartStatusService>().PropertiesAutowired();
            builder.RegisterType<CheckUpService>().As<ICheckUpService>().PropertiesAutowired();
            builder.RegisterType<CheckUpStatusService>().As<ICheckUpStatusService>().PropertiesAutowired();
            builder.RegisterType<ContractService>().As<IContractService>().PropertiesAutowired();
            builder.RegisterType<ContractStatusService>().As<IContractStatusService>().PropertiesAutowired();
            builder.RegisterType<ContractTypeService>().As<IContractTypeService>().PropertiesAutowired();
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
            builder.RegisterType<AccountTypeProcessor>().As<IAccountTypeProcessor>().PropertiesAutowired();
            builder.RegisterType<AutoPartProcessor>().As<IAutoPartProcessor>().PropertiesAutowired();
            builder.RegisterType<AutoPartStatusProcessor>().As<IAutoPartStatusProcessor>().PropertiesAutowired();
            builder.RegisterType<CheckUpProcessor>().As<ICheckUpProcessor>().PropertiesAutowired();
            builder.RegisterType<CheckUpStatusProcessor>().As<ICheckUpStatusProcessor>().PropertiesAutowired();
            builder.RegisterType<ContractProcessor>().As<IContractProcessor>().PropertiesAutowired();
            builder.RegisterType<ContractStatusProcessor>().As<IContractStatusProcessor>().PropertiesAutowired();
            builder.RegisterType<ContractTypeProcessor>().As<IContractTypeProcessor>().PropertiesAutowired();
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
            builder.RegisterType<AccountDaoFile>().As<IAccountDao>().PropertiesAutowired();
            builder.RegisterType<AccountStatusDaoFile>().As<IAccountStatusDao>().PropertiesAutowired();
            builder.RegisterType<AccountTypeDaoFile>().As<IAccountTypeDao>().PropertiesAutowired();
            builder.RegisterType<AutoPartDaoFile>().As<IAutoPartDao>().PropertiesAutowired();
            builder.RegisterType<AutoPartStatusDaoFile>().As<IAutoPartStatusDao>().PropertiesAutowired();
            builder.RegisterType<CheckUpDaoFile>().As<ICheckUpDao>().PropertiesAutowired();
            builder.RegisterType<CheckUpStatusDaoFile>().As<ICheckUpStatusDao>().PropertiesAutowired();
            builder.RegisterType<ContractDaoFile>().As<IContractDao>().PropertiesAutowired();
            builder.RegisterType<ContractStatusDaoFile>().As<IContractStatusDao>().PropertiesAutowired();
            builder.RegisterType<ContractTypeDaoFile>().As<IContractTypeDao>().PropertiesAutowired();
            builder.RegisterType<IssueDaoFile>().As<IIssueDao>().PropertiesAutowired();
            builder.RegisterType<MakeDaoFile>().As<IMakeDao>().PropertiesAutowired();
            builder.RegisterType<ModelDaoFile>().As<IModelDao>().PropertiesAutowired();
            builder.RegisterType<UserDaoFile>().As<IUserDao>().PropertiesAutowired();
            builder.RegisterType<UserGroupStatusDaoFile>().As<IUserGroupStatusDao>().PropertiesAutowired();
            builder.RegisterType<UserUserGroupDaoFile>().As<IUserUserGroupDao>().PropertiesAutowired();
            builder.RegisterType<VehicleDaoFile>().As<IVehicleDao>().PropertiesAutowired();
            builder.RegisterType<VehicleMakeModelDaoFile>().As<IVehicleMakeModelDao>().PropertiesAutowired();
            builder.RegisterType<VehicleStatusDaoFile>().As<IVehicleStatusDao>().PropertiesAutowired();

            builder.RegisterType<AccountDaoEF>().As<IAccountDao>().PropertiesAutowired();
            builder.RegisterType<AccountStatusDaoEF>().As<IAccountStatusDao>().PropertiesAutowired();
            builder.RegisterType<AccountTypeDaoEF>().As<IAccountTypeDao>().PropertiesAutowired();
            builder.RegisterType<AutoPartDaoEF>().As<IAutoPartDao>().PropertiesAutowired();
            builder.RegisterType<AutoPartStatusDaoEF>().As<IAutoPartStatusDao>().PropertiesAutowired();
            builder.RegisterType<CheckUpDaoEF>().As<ICheckUpDao>().PropertiesAutowired();
            builder.RegisterType<CheckUpStatusDaoEF>().As<ICheckUpStatusDao>().PropertiesAutowired();
            builder.RegisterType<ContractDaoEF>().As<IContractDao>().PropertiesAutowired();
            builder.RegisterType<ContractStatusDaoEF>().As<IContractStatusDao>().PropertiesAutowired();
            builder.RegisterType<ContractTypeDaoEF>().As<IContractTypeDao>().PropertiesAutowired();
            builder.RegisterType<IssueDaoEF>().As<IIssueDao>().PropertiesAutowired();
            builder.RegisterType<MakeDaoEF>().As<IMakeDao>().PropertiesAutowired();
            builder.RegisterType<ModelDaoEF>().As<IModelDao>().PropertiesAutowired();
            builder.RegisterType<UserDaoEF>().As<IUserDao>().PropertiesAutowired();
            builder.RegisterType<UserGroupStatusDaoEF>().As<IUserGroupStatusDao>().PropertiesAutowired();
            builder.RegisterType<UserUserGroupDaoEF>().As<IUserUserGroupDao>().PropertiesAutowired();
            builder.RegisterType<VehicleDaoEF>().As<IVehicleDao>().PropertiesAutowired();
            builder.RegisterType<VehicleMakeModelDaoEF>().As<IVehicleMakeModelDao>().PropertiesAutowired();
            builder.RegisterType<VehicleStatusDaoEF>().As<IVehicleStatusDao>().PropertiesAutowired();

            //////////////////////////////////    ParamConvert    /////////////////////////////////
            builder.RegisterType<AccountParamConverter>().As<IAccountParamConverter>().PropertiesAutowired();
            builder.RegisterType<AccountStatusParamConvert>().As<IAccountStatusParamConverter>().PropertiesAutowired();
            builder.RegisterType<AccountTypeParamConvert>().As<IAccountTypeParamConverter>().PropertiesAutowired();
            builder.RegisterType<AutoPartParamConverter>().As<IAutoPartParamConverter>().PropertiesAutowired();
            builder.RegisterType<AutoPartStatusParamConverter>().As<IAutoPartStatusParamConverter>().PropertiesAutowired();
            builder.RegisterType<CheckUpParamConverter>().As<ICheckUpParamConverter>().PropertiesAutowired();
            builder.RegisterType<CheckUpStatusParamConverter>().As<ICheckUpStatusParamConverter>().PropertiesAutowired();
            builder.RegisterType<ContractParamConverter>().As<IContractParamconverter>().PropertiesAutowired();
            builder.RegisterType<ContractStatusParamConverter>().As<IContractStatusParamConverter>().PropertiesAutowired();
            builder.RegisterType<ContractTypeParamConverter>().As<IContractTypeParamConverter>().PropertiesAutowired();
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
            builder.RegisterType<AccountTypeResultConvert>().As<IAccountTypeResultConverter>().PropertiesAutowired();
            builder.RegisterType<AutoPartResultConverter>().As<IAutoPartResultConvert>();
            builder.RegisterType<AutoPartStatusResultConverter>().As<IAutoPartStatusResultConverter>();
            builder.RegisterType<CheckUpResultConverter>().As<ICheckUpResultConverter>();
            builder.RegisterType<CheckUpStatusResultConverter>().As<ICheckUpStatusResultConverter>();
            builder.RegisterType<ContractResultConverter>().As<IContractResultConverter>();
            builder.RegisterType<ContractStatusResultConverter>().As<IContractStatusResultConverter>();
            builder.RegisterType<ContractTypeResultConverter>().As<IContractTypeResultConverter>();
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
