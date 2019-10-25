using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Employee;
using AutoServiceShop.Business.Processor.Employee;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Employee
{
    class EmployeeService : IEmployeeService
    {
        IEmployeeProcessor EmployeeProcessor = new EmployeeProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(EmployeeParam param)
        {
            EmployeeProcessor = new EmployeeProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(EmployeeProcessor.Create(param));
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

        public ApiResponse Create(List<EmployeeParam> param)
        {
            EmployeeProcessor = new EmployeeProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(EmployeeProcessor.Create(param));
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
            EmployeeProcessor = new EmployeeProcessor();
            Response = new ApiResponse();

            try
            {
                EmployeeProcessor.Delete(idList);
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
            EmployeeProcessor = new EmployeeProcessor();
            Response = new ApiResponse();

            try
            {
                EmployeeProcessor.Delete(id);
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
            EmployeeProcessor = new EmployeeProcessor();
            Response = new ApiResponse();

            try
            {
                EmployeeProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(EmployeeProcessor.Find(id));
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
            EmployeeProcessor = new EmployeeProcessor();
            Response = new ApiResponse();

            try
            {
                EmployeeProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(EmployeeProcessor.Find());
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

        public ApiResponse Update(long id, EmployeeParam param)
        {
            EmployeeProcessor = new EmployeeProcessor();
            Response = new ApiResponse();

            try
            {
                EmployeeProcessor.Update(id, param);
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

        public ApiResponse Update(List<EmployeeParam> param)
        {
            EmployeeProcessor = new EmployeeProcessor();
            Response = new ApiResponse();

            try
            {
                EmployeeProcessor.Update(param);

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

        public void ValidateParameters(EmployeeParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<EmployeeParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
