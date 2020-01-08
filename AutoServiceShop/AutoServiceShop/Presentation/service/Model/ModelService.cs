using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Model;
using AutoServiceShop.Business.Processor.Model;
using AutoServiceShop.Data.Common;
using AutoServiceShop.Dataaccess.Dao.Model;
using AutoServiceShop.Presentation.service.Common;

namespace AutoServiceShop.Presentation.service.Model
{
    public class ModelService
        : BaseService<IModelProcessor, IModelParamConverter, IModelResultConverter, ModelParam, ModelResult, IModelDao, long, Data.Entity.Model>, IModelService
    {
<<<<<<< Updated upstream
        IModelProcessor ModelProcessor = new ModelProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(ModelParam param)
        {
            ModelProcessor = new ModelProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(ModelProcessor.Create(param));
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
            ModelProcessor = new ModelProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(ModelProcessor.Create(param));
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
            ModelProcessor = new ModelProcessor();
            Response = new ApiResponse();

            try
            {
                ModelProcessor.Delete(idList);
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
            ModelProcessor = new ModelProcessor();
            Response = new ApiResponse();

            try
            {
                ModelProcessor.Delete(id);
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
            ModelProcessor = new ModelProcessor();
            Response = new ApiResponse();

            try
            {
                ModelProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(ModelProcessor.Find(id));
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
            ModelProcessor = new ModelProcessor();
            Response = new ApiResponse();

            try
            {
                ModelProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(ModelProcessor.Find());
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
            ModelProcessor = new ModelProcessor();
            Response = new ApiResponse();

            try
            {
                ModelProcessor.Update(id, param);
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
            ModelProcessor = new ModelProcessor();
            Response = new ApiResponse();

            try
            {
                ModelProcessor.Update(param);

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
=======
        
>>>>>>> Stashed changes
    }
}
