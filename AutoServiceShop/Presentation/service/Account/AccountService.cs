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
        public IAccountProcessor AccountProcessor = new AccountProcessor();

        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(AccountParam param)
        {
            AccountProcessor = new AccountProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(AccountProcessor.Create(param));
                Response.result = true;

                return Response;
            }

            catch
            {
                Response.text = "Something went wrong :(";
                Response.result = false;

                return Response;
            }

        }
        
        public ApiResponse Create(List<AccountParam> param)
        {
            AccountProcessor = new AccountProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(AccountProcessor.Create(param));
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "Something went wrong :(";
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse Delete(List<long> idList)
        {
            AccountProcessor = new AccountProcessor();
            Response = new ApiResponse();

            try
            {
                AccountProcessor.Delete(idList);
                Response.text = "Entity was successfully removed from the system.";
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "Unfortunately something went wrong. Try again later. :)";
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse DeleteById(long id)
        {
            AccountProcessor = new AccountProcessor();
            Response = new ApiResponse();

            try
            {
                AccountProcessor.Delete(id);
                Response.text = "Entity was successfully removed from the system.";
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "Unfortunately something went wrong :(";
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse FindByPK(long id)
        {
            AccountProcessor = new AccountProcessor();
            Response = new ApiResponse();

            try
            {
                AccountProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(AccountProcessor.Find(id));
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "An account with this id does not exist";
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse ListAll()
        {
            AccountProcessor = new AccountProcessor();
            Response = new ApiResponse();

            try
            {
                AccountProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(AccountProcessor.Find());
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "Unfortunately something went wrong :(";
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse Update(long id, AccountParam param)
        {
            AccountProcessor = new AccountProcessor();
            Response = new ApiResponse();

            try
            {
                AccountProcessor.Update(id, param);
                Response.text = "Entity was successfully updated";
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "Unfortunately something went wrong :(";
                Response.result = false;

                return Response;
            }

        }

        public ApiResponse Update(List<AccountParam> param)
        {
            AccountProcessor = new AccountProcessor();
            Response = new ApiResponse();

            try
            {
                AccountProcessor.Update(param);

                Response.text = "Entities were successfully updated.";
                Response.result = true;

                return Response;
            }
            catch
            {
                Response.text = "Unfortunately something went wrong :(";
                Response.result = false;

                return Response;
            }

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
