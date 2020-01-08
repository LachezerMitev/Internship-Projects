using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.UserGroup;
using AutoServiceShop.Business.Processor.UserGroup;
using AutoServiceShop.Data.Common;
using AutoServiceShop.Dataaccess.Dao.UserGroup;
using AutoServiceShop.Presentation.service.Common;

namespace AutoServiceShop.Presentation.service.UserGroup
{
    public class UserGroupService
        : BaseService<IUserGroupProcessor, IUserGroupParamConverter, IUserGroupResultConverter, UserGroupParam, UserGroupResult, IUserGroupDao, long, Data.Entity.UserGroup>, IUserGroupService
    {
<<<<<<< Updated upstream
        IUserGroupProcessor UserGroupProcessor = new UserGroupProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(UserGroupParam param)
        {
            UserGroupProcessor = new UserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(UserGroupProcessor.Create(param));
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

        public ApiResponse Create(List<UserGroupParam> param)
        {
            UserGroupProcessor = new UserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(UserGroupProcessor.Create(param));
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
            UserGroupProcessor = new UserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                UserGroupProcessor.Delete(idList);
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
            UserGroupProcessor = new UserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                UserGroupProcessor.Delete(id);
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
            UserGroupProcessor = new UserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                UserGroupProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(UserGroupProcessor.Find(id));
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
            UserGroupProcessor = new UserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                UserGroupProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(UserGroupProcessor.Find());
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

        public ApiResponse Update(long id, UserGroupParam param)
        {
            UserGroupProcessor = new UserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                UserGroupProcessor.Update(id, param);
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

        public ApiResponse Update(List<UserGroupParam> param)
        {
            UserGroupProcessor = new UserGroupProcessor();
            Response = new ApiResponse();

            try
            {
                UserGroupProcessor.Update(param);

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

        public void ValidateParameters(UserGroupParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<UserGroupParam> param)
        {
            throw new NotImplementedException();
        }
=======
        
>>>>>>> Stashed changes
    }
}
