using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.EmployeeStatus;
using AutoServiceShop.Business.Processor.EmployeeStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.EmployeeStatus
{
    class EmployeeStatusService : IEmployeeStatusService
    {
        IEmployeeStatusProcessor EmployeeStatusProcessor = new EmployeeStatusProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(EmployeeStatusParam param)
        {
            EmployeeStatusProcessor = new EmployeeStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(EmployeeStatusProcessor.Create(param));
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

        public ApiResponse Create(List<EmployeeStatusParam> param)
        {
            EmployeeStatusProcessor = new EmployeeStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(EmployeeStatusProcessor.Create(param));
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
            EmployeeStatusProcessor = new EmployeeStatusProcessor();
            Response = new ApiResponse();

            try
            {
                EmployeeStatusProcessor.Delete(idList);
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
            EmployeeStatusProcessor = new EmployeeStatusProcessor();
            Response = new ApiResponse();

            try
            {
                EmployeeStatusProcessor.Delete(id);
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
            EmployeeStatusProcessor = new EmployeeStatusProcessor();
            Response = new ApiResponse();

            try
            {
                EmployeeStatusProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(EmployeeStatusProcessor.Find(id));
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
            EmployeeStatusProcessor = new EmployeeStatusProcessor();
            Response = new ApiResponse();

            try
            {
                EmployeeStatusProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(EmployeeStatusProcessor.Find());
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

        public ApiResponse Update(long id, EmployeeStatusParam param)
        {
            EmployeeStatusProcessor = new EmployeeStatusProcessor();
            Response = new ApiResponse();

            try
            {
                EmployeeStatusProcessor.Update(id, param);
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

        public ApiResponse Update(List<EmployeeStatusParam> param)
        {
            EmployeeStatusProcessor = new EmployeeStatusProcessor();
            Response = new ApiResponse();

            try
            {
                EmployeeStatusProcessor.Update(param);

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

        public void ValidateParameters(EmployeeStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<EmployeeStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
