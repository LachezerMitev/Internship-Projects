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
        private IEmployeeStatusProcessor _employeeStatusProcessor;
        public IEmployeeStatusProcessor EmployeeStatusProcessor
        {
            set => _employeeStatusProcessor = value;
            get
            {
                if (_employeeStatusProcessor == null)
                {
                    _employeeStatusProcessor = new EmployeeStatusProcessor();
                    return _employeeStatusProcessor;
                }
                else
                {
                    return _employeeStatusProcessor;
                }
            }
        }

        public ApiResponse Create(EmployeeStatusParam param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_employeeStatusProcessor.Create(param));
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
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_employeeStatusProcessor.Create(param));
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
                _employeeStatusProcessor.Delete(idList);
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
                _employeeStatusProcessor.Delete(id);
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
                _employeeStatusProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(_employeeStatusProcessor.Find(id));
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
                _employeeStatusProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(_employeeStatusProcessor.Find());
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _employeeStatusProcessor.Update(id, param);
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _employeeStatusProcessor.Update(param);

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
