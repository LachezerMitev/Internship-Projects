using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.UserUserGroup;
using AutoServiceShop.Business.Processor.UserUserGroup;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.UserUserGroup
{
    class UserUserGroupService : IUserUserGroupService
    {
<<<<<<< Updated upstream
        IUserUserGroupProcessor UserUserGroupProcessor = new UserUserGroupProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(UserUserGroupParam param)
        {
            UserUserGroupProcessor = new UserUserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(UserUserGroupProcessor.Create(param));
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

        public ApiResponse Create(List<UserUserGroupParam> param)
        {
            UserUserGroupProcessor = new UserUserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(UserUserGroupProcessor.Create(param));
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
            UserUserGroupProcessor = new UserUserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                UserUserGroupProcessor.Delete(idList);
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
            UserUserGroupProcessor = new UserUserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                UserUserGroupProcessor.Delete(id);
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
            UserUserGroupProcessor = new UserUserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                UserUserGroupProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(UserUserGroupProcessor.Find(id));
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
            UserUserGroupProcessor = new UserUserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                UserUserGroupProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(UserUserGroupProcessor.Find());
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

        public ApiResponse Update(long id, UserUserGroupParam param)
        {
            UserUserGroupProcessor = new UserUserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                UserUserGroupProcessor.Update(id, param);
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

        public ApiResponse Update(List<UserUserGroupParam> param)
        {
            UserUserGroupProcessor = new UserUserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                UserUserGroupProcessor.Update(param);

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

        public void ValidateParameters(UserUserGroupParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<UserUserGroupParam> param)
        {
            throw new NotImplementedException();
        }
=======
        
>>>>>>> Stashed changes
    }
}
