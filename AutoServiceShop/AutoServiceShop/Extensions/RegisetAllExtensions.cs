using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Extensions
{
    public static class RegisetAllExtensions
    {
        public static void RegisterExtensions(IServiceCollection services, bool useDB)
        {
            RegisterAccountExtensions.RegiserDependencies(services, useDB);
            RegisterAccountStatusExtensions.RegiserDependencies(services, useDB);
            RegisterAccountTypeExtensions.RegiserDependencies(services, useDB);
            RegisterAutoPartExtensions.RegiserDependencies(services, useDB);
            RegisterAutoPartStatusExtensions.RegiserDependencies(services, useDB);
            RegisterCheckUpExtensions.RegiserDependencies(services, useDB);
            RegisterCheckUpStatusExtensions.RegiserDependencies(services, useDB);
            RegisterContractExtensions.RegiserDependencies(services, useDB);
            RegisterContractStatusExtensions.RegiserDependencies(services, useDB);
            RegisterContractTypeExtensions.RegiserDependencies(services, useDB);
            RegisterIssueExtensions.RegiserDependencies(services, useDB);
            RegisterMakeExtensions.RegiserDependencies(services, useDB);
            RegisterModelExtensions.RegiserDependencies(services, useDB);
            RegisterUserExtensions.RegiserDependencies(services, useDB);
            RegisterUserGroupExtensions.RegiserDependencies(services, useDB);
            RegisterUserGroupStatusExtensions.RegiserDependencies(services, useDB);
            RegisterVehicleExtensions.RegiserDependencies(services, useDB);
            RegisterVehicleMakeModelExtensions.RegiserDependencies(services, useDB);
            RegisterVehicleStatusExtensions.RegiserDependencies(services, useDB);
            RegisterUserUserGroupExtensions.RegiserDependencies(services, useDB);
            RegisterAuthenticationProviderExtensions.RegiserDependencies(services);
            RegisterLogInExtensions.RegiserDependencies(services);
        }
    }
}
