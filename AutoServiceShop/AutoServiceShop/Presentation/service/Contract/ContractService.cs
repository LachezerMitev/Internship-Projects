using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.Contract;
using AutoServiceShop.Business.Processor.Converter.Contract;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Contract
{
    class ContractService : IContractService
    {
        IContractProcessor ContractProcessor = new ContractProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(ContractParam param)
        {
            ContractProcessor = new ContractProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(ContractProcessor.Create(param));
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

        public ApiResponse Create(List<ContractParam> param)
        {
            ContractProcessor = new ContractProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(ContractProcessor.Create(param));
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
            ContractProcessor = new ContractProcessor();
            Response = new ApiResponse();

            try
            {
                ContractProcessor.Delete(idList);
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
            ContractProcessor = new ContractProcessor();
            Response = new ApiResponse();

            try
            {
                ContractProcessor.Delete(id);
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
            ContractProcessor = new ContractProcessor();
            Response = new ApiResponse();

            try
            {
                ContractProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(ContractProcessor.Find(id));
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
            ContractProcessor = new ContractProcessor();
            Response = new ApiResponse();

            try
            {
                ContractProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(ContractProcessor.Find());
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

        public ApiResponse Update(long id, ContractParam param)
        {
            ContractProcessor = new ContractProcessor();
            Response = new ApiResponse();

            try
            {
                ContractProcessor.Update(id, param);
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

        public ApiResponse Update(List<ContractParam> param)
        {
            ContractProcessor = new ContractProcessor();
            Response = new ApiResponse();

            try
            {
                ContractProcessor.Update(param);

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

        public void ValidateParameters(ContractParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<ContractParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
