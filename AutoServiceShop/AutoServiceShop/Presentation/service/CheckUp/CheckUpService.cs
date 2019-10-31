using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.CheckUp;
using AutoServiceShop.Business.Processor.Converter.CheckUp;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.CheckUp
{
    class CheckUpService : ICheckUpService
    {
        ICheckUpProcessor CheckUpProcessor = new CheckUpProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(CheckUpParam param)
        {
            CheckUpProcessor = new CheckUpProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(CheckUpProcessor.Create(param));
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

        public ApiResponse Create(List<CheckUpParam> param)
        {
            CheckUpProcessor = new CheckUpProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(CheckUpProcessor.Create(param));
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
            CheckUpProcessor = new CheckUpProcessor();
            Response = new ApiResponse();

            try
            {
                CheckUpProcessor.Delete(idList);
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
            CheckUpProcessor = new CheckUpProcessor();
            Response = new ApiResponse();

            try
            {
                CheckUpProcessor.Delete(id);
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
            CheckUpProcessor = new CheckUpProcessor();
            Response = new ApiResponse();

            try
            {
                CheckUpProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(CheckUpProcessor.Find(id));
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
            CheckUpProcessor = new CheckUpProcessor();
            Response = new ApiResponse();

            try
            {
                CheckUpProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(CheckUpProcessor.Find());
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

        public ApiResponse Update(long id, CheckUpParam param)
        {
            CheckUpProcessor = new CheckUpProcessor();
            Response = new ApiResponse();

            try
            {
                CheckUpProcessor.Update(id, param);
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

        public ApiResponse Update(List<CheckUpParam> param)
        {
            CheckUpProcessor = new CheckUpProcessor();
            Response = new ApiResponse();

            try
            {
                CheckUpProcessor.Update(param);

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

        public void ValidateParameters(CheckUpParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<CheckUpParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
