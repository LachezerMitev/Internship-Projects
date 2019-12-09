using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;
using AutoServiceShop.Business.Processor.UserGroupStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.UserGroupStatus
{
    class UserGroupStatusService : IUserGroupStatusService
    {
        private IUserGroupStatusProcessor _userGroupStatusProcessor;
        public IUserGroupStatusProcessor UserGroupStatusProcessor
        {
            set => _userGroupStatusProcessor = value;
            get
            {
                if (_userGroupStatusProcessor == null)
                {
                    _userGroupStatusProcessor = new UserGroupStatusProcessor();
                    return _userGroupStatusProcessor;
                }
                else
                {
                    return _userGroupStatusProcessor;
                }
            }
        }

        public ApiResponse Create(UserGroupStatusParam param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_userGroupStatusProcessor.Create(param));
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

        public ApiResponse Create(List<UserGroupStatusParam> param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_userGroupStatusProcessor.Create(param));
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _userGroupStatusProcessor.Delete(idList);
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _userGroupStatusProcessor.Delete(id);
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _userGroupStatusProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(_userGroupStatusProcessor.Find(id));
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _userGroupStatusProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(_userGroupStatusProcessor.Find());
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

        public ApiResponse Update(long id, UserGroupStatusParam param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _userGroupStatusProcessor.Update(id, param);
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

        public ApiResponse Update(List<UserGroupStatusParam> param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _userGroupStatusProcessor.Update(param);

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

        public void ValidateParameters(UserGroupStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<UserGroupStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
