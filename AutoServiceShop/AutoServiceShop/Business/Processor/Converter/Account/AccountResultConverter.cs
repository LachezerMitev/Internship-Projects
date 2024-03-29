﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using Newtonsoft.Json;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    class AccountResultConverter : IAccountResultConverter
    {
        public AccountResult Convert(Data.Entity.Account param)
        {
            
            AccountResult result = new AccountResult()
            {
                Code = param.Code,
                Id = param.Id,
                Description = param.Description,
                Name = param.Name,
                FirstName = param.FirstName,
                Surname = param.Surname,
                LastName = param.LastName,
                Type = param.Type,

                AccountStatusId = param.AccountStatus.Id,
                UserId = param.User.Id,
                AccountStatusName = param.AccountStatus.Name,
                Username = param.User.Username
                
            };

            return result;
        }
    }
}
