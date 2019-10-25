using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.AutoPartStatus;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.AutoPartStatus
{
    class AutoPartStatusService : IAutoPartStatusService
    {
        IAutoPartStatusProcessor AutoPartStatusProcessor = new AutoPartStatusProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(AutoPartStatusParam param)
        {
            AutoPartStatusProcessor = new AutoPartStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(AutoPartStatusProcessor.Create(param));
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

        public ApiResponse Create(List<AutoPartStatusParam> param)
        {
            AutoPartStatusProcessor = new AutoPartStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(AutoPartStatusProcessor.Create(param));
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
            AutoPartStatusProcessor = new AutoPartStatusProcessor();
            Response = new ApiResponse();

            try
            {
                AutoPartStatusProcessor.Delete(idList);
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
            AutoPartStatusProcessor = new AutoPartStatusProcessor();
            Response = new ApiResponse();

            try
            {
                AutoPartStatusProcessor.Delete(id);
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
            AutoPartStatusProcessor = new AutoPartStatusProcessor();
            Response = new ApiResponse();

            try
            {
                AutoPartStatusProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(AutoPartStatusProcessor.Find(id));
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
            AutoPartStatusProcessor = new AutoPartStatusProcessor();
            Response = new ApiResponse();

            try
            {
                AutoPartStatusProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(AutoPartStatusProcessor.Find());
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

        public ApiResponse Update(long id, AutoPartStatusParam param)
        {
            AutoPartStatusProcessor = new AutoPartStatusProcessor();
            Response = new ApiResponse();

            try
            {
                AutoPartStatusProcessor.Update(id, param);
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

        public ApiResponse Update(List<AutoPartStatusParam> param)
        {
            AutoPartStatusProcessor = new AutoPartStatusProcessor();
            Response = new ApiResponse();

            try
            {
                AutoPartStatusProcessor.Update(param);

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

        public void ValidateParameters(AutoPartStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AutoPartStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
