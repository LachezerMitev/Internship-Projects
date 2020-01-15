using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.ContractType;
using AutoServiceShop.Business.Processor.Converter.ContractType;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.ContractType
{
    class ContractTypeService : IContractTypeService
    {
<<<<<<< Updated upstream
       IContractTypeProcessor ContractTypeProcessor = new ContractTypeProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(ContractTypeParam param)
        {
            ContractTypeProcessor = new ContractTypeProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(ContractTypeProcessor.Create(param));
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

        public ApiResponse Create(List<ContractTypeParam> param)
        {
            ContractTypeProcessor = new ContractTypeProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(ContractTypeProcessor.Create(param));
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
            ContractTypeProcessor = new ContractTypeProcessor();
            Response = new ApiResponse();

            try
            {
                ContractTypeProcessor.Delete(idList);
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
            ContractTypeProcessor = new ContractTypeProcessor();
            Response = new ApiResponse();

            try
            {
                ContractTypeProcessor.Delete(id);
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
            ContractTypeProcessor = new ContractTypeProcessor();
            Response = new ApiResponse();

            try
            {
                ContractTypeProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(ContractTypeProcessor.Find(id));
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
            ContractTypeProcessor = new ContractTypeProcessor();
            Response = new ApiResponse();

            try
            {
                ContractTypeProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(ContractTypeProcessor.Find());
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

        public ApiResponse Update(long id, ContractTypeParam param)
        {
            ContractTypeProcessor = new ContractTypeProcessor();
            Response = new ApiResponse();

            try
            {
                ContractTypeProcessor.Update(id, param);
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

        public ApiResponse Update(List<ContractTypeParam> param)
        {
            ContractTypeProcessor = new ContractTypeProcessor();
            Response = new ApiResponse();

            try
            {
                ContractTypeProcessor.Update(param);

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

        public void ValidateParameters(ContractTypeParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<ContractTypeParam> param)
        {
            throw new NotImplementedException();
        }
=======
>>>>>>> Stashed changes
    }
}
