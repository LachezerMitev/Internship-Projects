using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.CheckUpStatus
{
    class CheckUpStatusService : ICheckUpStatusService
    {
        private ICheckUpStatusProcessor _checkUpStatusProcessor;
        public ICheckUpStatusProcessor CheckUpStatusProcessor
        {
            set => _checkUpStatusProcessor = value;
            get
            {
                if (_checkUpStatusProcessor == null)
                {
                    _checkUpStatusProcessor = new CheckUpStatusProcessor();
                    return _checkUpStatusProcessor;
                }
                else
                {
                    return _checkUpStatusProcessor;
                }
            }
        }

        public ApiResponse Create(CheckUpStatusParam param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_checkUpStatusProcessor.Create(param));
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

        public ApiResponse Create(List<CheckUpStatusParam> param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_checkUpStatusProcessor.Create(param));
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
                _checkUpStatusProcessor.Delete(idList);
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
                _checkUpStatusProcessor.Delete(id);
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
                _checkUpStatusProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(_checkUpStatusProcessor.Find(id));
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
                _checkUpStatusProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(_checkUpStatusProcessor.Find());
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

        public ApiResponse Update(long id, CheckUpStatusParam param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _checkUpStatusProcessor.Update(id, param);
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

        public ApiResponse Update(List<CheckUpStatusParam> param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _checkUpStatusProcessor.Update(param);

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

        public void ValidateParameters(CheckUpStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<CheckUpStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
