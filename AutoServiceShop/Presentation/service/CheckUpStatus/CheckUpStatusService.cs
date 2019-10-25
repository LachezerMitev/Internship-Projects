using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.CheckUpStatus
{
    class CheckUpStatusService : ICheckUpStatusService
    {
        ICheckUpStatusProcessor CheckUpStatusProcessor = new CheckUpStatusProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(CheckUpStatusParam param)
        {
            CheckUpStatusProcessor = new CheckUpStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(CheckUpStatusProcessor.Create(param));
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

        public ApiResponse Create(List<CheckUpStatusParam> param)
        {
            CheckUpStatusProcessor = new CheckUpStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(CheckUpStatusProcessor.Create(param));
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
            CheckUpStatusProcessor = new CheckUpStatusProcessor();
            Response = new ApiResponse();

            try
            {
                CheckUpStatusProcessor.Delete(idList);
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
            CheckUpStatusProcessor = new CheckUpStatusProcessor();
            Response = new ApiResponse();

            try
            {
                CheckUpStatusProcessor.Delete(id);
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
            CheckUpStatusProcessor = new CheckUpStatusProcessor();
            Response = new ApiResponse();

            try
            {
                CheckUpStatusProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(CheckUpStatusProcessor.Find(id));
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
            CheckUpStatusProcessor = new CheckUpStatusProcessor();
            Response = new ApiResponse();

            try
            {
                CheckUpStatusProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(CheckUpStatusProcessor.Find());
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

        public ApiResponse Update(long id, CheckUpStatusParam param)
        {
            CheckUpStatusProcessor = new CheckUpStatusProcessor();
            Response = new ApiResponse();

            try
            {
                CheckUpStatusProcessor.Update(id, param);
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

        public ApiResponse Update(List<CheckUpStatusParam> param)
        {
            CheckUpStatusProcessor = new CheckUpStatusProcessor();
            Response = new ApiResponse();

            try
            {
                CheckUpStatusProcessor.Update(param);

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

        public void ValidateParameters(CheckUpStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<CheckUpStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
