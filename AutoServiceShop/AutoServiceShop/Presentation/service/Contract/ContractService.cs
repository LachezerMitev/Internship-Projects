﻿using System;
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
        private IContractProcessor _contractProcessor;
        public IContractProcessor ContractProcessor
        {
            set => _contractProcessor = value;
            get
            {
                if (_contractProcessor == null)
                {
                    _contractProcessor = new ContractProcessor();
                    return _contractProcessor;
                }
                else
                {
                    return _contractProcessor;
                }
            }
        }

        public ApiResponse Create(ContractParam param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_contractProcessor.Create(param));
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
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_contractProcessor.Create(param));
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
                _contractProcessor.Delete(idList);
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
                _contractProcessor.Delete(id);
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
                _contractProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(_contractProcessor.Find(id));
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
                _contractProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(_contractProcessor.Find());
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _contractProcessor.Update(id, param);
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _contractProcessor.Update(param);

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