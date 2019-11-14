using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Customer;
using AutoServiceShop.Business.Processor.Customer;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Customer
{
    class CustomerService : ICustomerService
    {
        ICustomerProcessor CustomerProcessor = new CustomerProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(CustomerParam param)
        {
            CustomerProcessor = new CustomerProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(CustomerProcessor.Create(param));
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

        public ApiResponse Create(List<CustomerParam> param)
        {
            CustomerProcessor = new CustomerProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(CustomerProcessor.Create(param));
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
            CustomerProcessor = new CustomerProcessor();
            Response = new ApiResponse();

            try
            {
                CustomerProcessor.Delete(idList);
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
            CustomerProcessor = new CustomerProcessor();
            Response = new ApiResponse();

            try
            {
                CustomerProcessor.Delete(id);
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
            CustomerProcessor = new CustomerProcessor();
            Response = new ApiResponse();

            try
            {
                CustomerProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(CustomerProcessor.Find(id));
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
            CustomerProcessor = new CustomerProcessor();
            Response = new ApiResponse();

            try
            {
                CustomerProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(CustomerProcessor.Find());
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

        public ApiResponse Update(long id, CustomerParam param)
        {
            CustomerProcessor = new CustomerProcessor();
            Response = new ApiResponse();

            try
            {
                CustomerProcessor.Update(id, param);
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

        public ApiResponse Update(List<CustomerParam> param)
        {
            CustomerProcessor = new CustomerProcessor();
            Response = new ApiResponse();

            try
            {
                CustomerProcessor.Update(param);

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

        public void ValidateParameters(CustomerParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<CustomerParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
