using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.ContractStatus;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using AutoServiceShop.Data.Common;
using AutoServiceShop.Dataaccess.Dao.ContractStatus;
using AutoServiceShop.Presentation.service.Common;

namespace AutoServiceShop.Presentation.service.ContractStatus
{
    public class ContractStatusService
        : BaseService<IContractStatusProcessor, IContractStatusParamConverter, IContractStatusResultConverter, ContractStatusParam, ContractStatusResult, IContractStatusDao, long, Data.Entity.ContractStatus>, IContractStatusService
    {
<<<<<<< Updated upstream
        IContractStatusProcessor ContractStatusProcessor = new ContractStatusProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(ContractStatusParam param)
        {
            ContractStatusProcessor = new ContractStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(ContractStatusProcessor.Create(param));
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

        public ApiResponse Create(List<ContractStatusParam> param)
        {
            ContractStatusProcessor = new ContractStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(ContractStatusProcessor.Create(param));
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
            ContractStatusProcessor = new ContractStatusProcessor();
            Response = new ApiResponse();

            try
            {
                ContractStatusProcessor.Delete(idList);
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
            ContractStatusProcessor = new ContractStatusProcessor();
            Response = new ApiResponse();

            try
            {
                ContractStatusProcessor.Delete(id);
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
            ContractStatusProcessor = new ContractStatusProcessor();
            Response = new ApiResponse();

            try
            {
                ContractStatusProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(ContractStatusProcessor.Find(id));
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
            ContractStatusProcessor = new ContractStatusProcessor();
            Response = new ApiResponse();

            try
            {
                ContractStatusProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(ContractStatusProcessor.Find());
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

        public ApiResponse Update(long id, ContractStatusParam param)
        {
            ContractStatusProcessor = new ContractStatusProcessor();
            Response = new ApiResponse();

            try
            {
                ContractStatusProcessor.Update(id, param);
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

        public ApiResponse Update(List<ContractStatusParam> param)
        {
            ContractStatusProcessor = new ContractStatusProcessor();
            Response = new ApiResponse();

            try
            {
                ContractStatusProcessor.Update(param);

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

        public void ValidateParameters(ContractStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<ContractStatusParam> param)
        {
            throw new NotImplementedException();
        }
=======
        
>>>>>>> Stashed changes
    }
}
