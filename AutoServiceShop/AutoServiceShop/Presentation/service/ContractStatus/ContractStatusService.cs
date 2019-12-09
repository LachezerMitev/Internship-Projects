using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.ContractStatus;
using AutoServiceShop.Business.Processor.Converter.ContractStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.ContractStatus
{
    class ContractStatusService : IContractStatusService
    {
        private IContractStatusProcessor _contractStatusProcessor;
        public IContractStatusProcessor ContractStatusProcessor
        {
            set => _contractStatusProcessor = value;
            get
            {
                if (_contractStatusProcessor == null)
                {
                    _contractStatusProcessor = new ContractStatusProcessor();
                    return _contractStatusProcessor;
                }
                else
                {
                    return _contractStatusProcessor;
                }
            }
        }

        public ApiResponse Create(ContractStatusParam param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_contractStatusProcessor.Create(param));
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
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_contractStatusProcessor.Create(param));
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
                _contractStatusProcessor.Delete(idList);
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
                _contractStatusProcessor.Delete(id);
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
                _contractStatusProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(_contractStatusProcessor.Find(id));
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
                _contractStatusProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(_contractStatusProcessor.Find());
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _contractStatusProcessor.Update(id, param);
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _contractStatusProcessor.Update(param);

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
    }
}
