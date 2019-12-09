using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Model;
using AutoServiceShop.Business.Processor.Model;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Model
{
    class ModelService : IModelService
    {
        private IModelProcessor _modelProcessor;
        public IModelProcessor ModelProcessor
        {
            set => _modelProcessor = value;
            get
            {
                if (_modelProcessor == null)
                {
                    _modelProcessor = new ModelProcessor();
                    return _modelProcessor;
                }
                else
                {
                    return _modelProcessor;
                }
            }
        }

        public ApiResponse Create(ModelParam param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_modelProcessor.Create(param));
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

        public ApiResponse Create(List<ModelParam> param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_modelProcessor.Create(param));
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
                _modelProcessor.Delete(idList);
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
                _modelProcessor.Delete(id);
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
                _modelProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(_modelProcessor.Find(id));
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
                _modelProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(_modelProcessor.Find());
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

        public ApiResponse Update(long id, ModelParam param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _modelProcessor.Update(id, param);
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

        public ApiResponse Update(List<ModelParam> param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                _modelProcessor.Update(param);

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

        public void ValidateParameters(ModelParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<ModelParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
