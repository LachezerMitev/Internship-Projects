using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.CustomerStatus;
using AutoServiceShop.Business.Processor.CustomerStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.CustomerStatus
{
    class CustomerStatusService : ICustomerStatusService
    {
        ICustomerStatusProcessor CustomerStatusProcessor = new CustomerStatusProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(CustomerStatusParam param)
        {
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(CustomerStatusProcessor.Create(param));
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

        public ApiResponse Create(List<CustomerStatusParam> param)
        {
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(CustomerStatusProcessor.Create(param));
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
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
                CustomerStatusProcessor.Delete(idList);
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
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
                CustomerStatusProcessor.Delete(id);
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
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
                CustomerStatusProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(CustomerStatusProcessor.Find(id));
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
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
                CustomerStatusProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(CustomerStatusProcessor.Find());
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

        public ApiResponse Update(long id, CustomerStatusParam param)
        {
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
                CustomerStatusProcessor.Update(id, param);
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

        public ApiResponse Update(List<CustomerStatusParam> param)
        {
            CustomerStatusProcessor = new CustomerStatusProcessor();
            Response = new ApiResponse();

            try
            {
                CustomerStatusProcessor.Update(param);

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

        public void ValidateParameters(CustomerStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<CustomerStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
