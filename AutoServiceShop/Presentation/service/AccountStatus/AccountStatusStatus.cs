using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.AccountStatus;
using AutoServiceShop.Business.Processor.Converter.AccountStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.AccountStatus
{
    class AccountStatusStatus : IAccountStatusService
    {
        public IAccountStatusProcessor AccountStatusProcessor = new AccountStatusProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(AccountStatusParam param)
        {
            AccountStatusProcessor = new AccountStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(AccountStatusProcessor.Create(param));
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

        public ApiResponse Create(List<AccountStatusParam> param)
        {
            AccountStatusProcessor = new AccountStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(AccountStatusProcessor.Create(param));
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
            AccountStatusProcessor = new AccountStatusProcessor();
            Response = new ApiResponse();

            try
            {
                AccountStatusProcessor.Delete(idList);
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
            AccountStatusProcessor = new AccountStatusProcessor();
            Response = new ApiResponse();

            try
            {
                AccountStatusProcessor.Delete(id);
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
            AccountStatusProcessor = new AccountStatusProcessor();
            Response = new ApiResponse();

            try
            {
                AccountStatusProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(AccountStatusProcessor.Find(id));
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
            AccountStatusProcessor = new AccountStatusProcessor();
            Response = new ApiResponse();

            try
            {
                AccountStatusProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(AccountStatusProcessor.Find());
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

        public ApiResponse Update(long id, AccountStatusParam param)
        {
            AccountStatusProcessor = new AccountStatusProcessor();
            Response = new ApiResponse();

            try
            {
                AccountStatusProcessor.Update(id, param);
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

        public ApiResponse Update(List<AccountStatusParam> param)
        {
            AccountStatusProcessor = new AccountStatusProcessor();
            Response = new ApiResponse();

            try
            {
                AccountStatusProcessor.Update(param);

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

        public void ValidateParameters(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AccountStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
