using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.Account;
using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Account
{
    class AccountService : IAccountService
    {
        public AccountProcessor AccountProcessor { get; set; }

        public ApiResponse Response { get; set; }

        public ApiResponse Create(AccountParam param)
        {
            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(AccountProcessor.Create(param));
                Response.result = true;
            }
            catch
            {
                Response.text = "Something went wrong :(";
                Response.result = false;
            }

            return Response;
        }
        
        public ApiResponse Create(List<AccountParam> param)
        {
            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(AccountProcessor.Create(param));
                Response.result = true;
            }
            catch
            {
                Response.text = "Something went wrong :(";
                Response.result = false;
            }

            return Response;
        }

        public ApiResponse Delete(List<long> idList)
        {
            try
            {
                AccountProcessor.Delete(idList);
                Response.text = "Entity was successfully removed from the system.";
                Response.result = true;
            }
            catch
            {
                Response.text = "Unfortunately something went wrong. Try again later. :)";
                Response.result = false;
            }
            return Response;
        }

        public ApiResponse DeleteById(long id)
        {
            try
            {
                AccountProcessor.Delete(id);
                Response.text = "Entity was successfully removed from the system.";
                Response.result = true;
            }
            catch
            {
                Response.text = "Unfortunately something went wrong :(";
                Response.result = false;
            }
            return Response;
        }

        public ApiResponse FindByPK(long id)
        {
            try
            {
                AccountProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(AccountProcessor.Find(id));
                Response.result = true;
            }
            catch
            {
                Response.text = "An account with this id does not exist";
                Response.result = false;
            }
            return Response;
        }

        public ApiResponse ListAll()
        {
            try
            {
                AccountProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(AccountProcessor.Find());
                Response.result = true;
            }
            catch
            {
                Response.text = "Unfortunately something went wrong :(";
                Response.result = false;
            }
            return Response;
        }

        public ApiResponse Update(long id, AccountParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(AccountParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
