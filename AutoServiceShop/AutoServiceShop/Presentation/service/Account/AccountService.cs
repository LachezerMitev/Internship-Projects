using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.Account;
using AutoServiceShop.Business.Processor.Converter.Account;
using AutoServiceShop.Data.Common;
using AutoServiceShop.Dataaccess.Dao.Account;

namespace AutoServiceShop.Presentation.service.Account
{
    class AccountService : IAccountService
    {
        private IAccountProcessor _accountProcessor;
        public IAccountProcessor AccountProcessor
        {
            set => _accountProcessor = value;
            get
            {
                if (_accountProcessor == null)
                {
                    _accountProcessor = new AccountProcessor();
                    return _accountProcessor;
                }
                else
                {
                    return _accountProcessor;
                }
            }
        }

        public ApiResponse Create(AccountParam param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                
                Response.text = JsonConverter.JsonConverter.ObjToJson(_accountProcessor.Create(param));
                
                Response.result = true;

                return Response;
            }

            catch (Exception e)
            {

                Response.text = "Something went wrong :( " + e;
                Response.result = false;

                return Response;
            }

        }
        
        public ApiResponse Create(List<AccountParam> param)
        {
            
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_accountProcessor.Create(param));
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "Something went wrong :( " + e;
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse Delete(List<long> idList)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _accountProcessor.Delete(idList);
                Response.text = "Entity was successfully removed from the system.";
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "Unfortunately something went wrong. Try again later. :)" + e;
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse DeleteById(long id)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _accountProcessor.Delete(id);
                Response.text = "Entity was successfully removed from the system.";
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "Unfortunately something went wrong :(" + e;
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse FindByPK(long id)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _accountProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(AccountProcessor.Find(id));
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "An account with this id does not exist" + e;
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse FindByField(string field, string value)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _accountProcessor.FindByField(field, value);
                Response.text = JsonConverter.JsonConverter.ObjToJson(AccountProcessor.FindByField(field, value));
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "An account with this field or value doesn't exist" + e;
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse ListAll()
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _accountProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(AccountProcessor.Find());
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "Unfortunately something went wrong :(" + e;
                Response.result = false;

                return Response;
            }
        }

        public ApiResponse Update(long id, AccountParam param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _accountProcessor.Update(id, param);
                Response.text = "Entity was successfully updated";
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "Unfortunately something went wrong :(" + e;
                Response.result = false;

                return Response;
            }

        }

        public ApiResponse Update(List<AccountParam> param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _accountProcessor.Update(param);

                Response.text = "Entities were successfully updated.";
                Response.result = true;

                return Response;
            }
            catch (Exception e)
            {
                Response.text = "Unfortunately something went wrong :(" + e;
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
