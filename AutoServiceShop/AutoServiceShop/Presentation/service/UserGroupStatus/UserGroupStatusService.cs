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
<<<<<<< Updated upstream
        IUserGroupStatusProcessor UserGroupStatusProcessor = new UserGroupStatusProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(UserGroupStatusParam param)
        {
            UserGroupStatusProcessor = new UserGroupStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(UserGroupStatusProcessor.Create(param));
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
            UserGroupStatusProcessor = new UserGroupStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(UserGroupStatusProcessor.Create(param));
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
            UserGroupStatusProcessor = new UserGroupStatusProcessor();
            Response = new ApiResponse();

            try
            {
                UserGroupStatusProcessor.Delete(idList);
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
            UserGroupStatusProcessor = new UserGroupStatusProcessor();
            Response = new ApiResponse();

            try
            {
                UserGroupStatusProcessor.Delete(id);
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
            UserGroupStatusProcessor = new UserGroupStatusProcessor();
            Response = new ApiResponse();

            try
            {
                UserGroupStatusProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(UserGroupStatusProcessor.Find(id));
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
            UserGroupStatusProcessor = new UserGroupStatusProcessor();
            Response = new ApiResponse();

            try
            {
                UserGroupStatusProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(UserGroupStatusProcessor.Find());
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
            UserGroupStatusProcessor = new UserGroupStatusProcessor();
            Response = new ApiResponse();

            try
            {
                UserGroupStatusProcessor.Update(id, param);
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
            UserGroupStatusProcessor = new UserGroupStatusProcessor();
            Response = new ApiResponse();

            try
            {
                UserGroupStatusProcessor.Update(param);

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
=======
        
>>>>>>> Stashed changes
    }
}
