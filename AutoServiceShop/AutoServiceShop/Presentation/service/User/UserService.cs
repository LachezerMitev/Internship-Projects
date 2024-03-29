﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Business.Processor.User;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.User
{
    class UserService : IUserService
    {
        IUserProcessor UserProcessor = new UserProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(UserParam param)
        {
            UserProcessor = new UserProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(UserProcessor.Create(param));
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

        public ApiResponse Create(List<UserParam> param)
        {
            UserProcessor = new UserProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(UserProcessor.Create(param));
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
            UserProcessor = new UserProcessor();
            Response = new ApiResponse();

            try
            {
                UserProcessor.Delete(idList);
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
            UserProcessor = new UserProcessor();
            Response = new ApiResponse();

            try
            {
                UserProcessor.Delete(id);
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
            UserProcessor = new UserProcessor();
            Response = new ApiResponse();

            try
            {
                UserProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(UserProcessor.Find(id));
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
            UserProcessor = new UserProcessor();
            Response = new ApiResponse();

            try
            {
                UserProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(UserProcessor.Find());
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

        public ApiResponse Update(long id, UserParam param)
        {
            UserProcessor = new UserProcessor();
            Response = new ApiResponse();

            try
            {
                UserProcessor.Update(id, param);
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

        public ApiResponse Update(List<UserParam> param)
        {
            UserProcessor = new UserProcessor();
            Response = new ApiResponse();

            try
            {
                UserProcessor.Update(param);

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

        public void ValidateParameters(UserParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<UserParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
