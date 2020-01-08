using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.AutoPart;
using AutoServiceShop.Business.Processor.Converter.AutoPart;
using AutoServiceShop.Data.Common;
using AutoServiceShop.Dataaccess.Dao.AutoPart;
using AutoServiceShop.Presentation.service.Common;

namespace AutoServiceShop.Presentation.service.AutoPart
{
    public class AutoPartService
        : BaseService<IAutoPartProcessor, IAutoPartParamConverter, IAutoPartResultConvert, AutoPartParam, AutoPartResult, IAutoPartDao, long, Data.Entity.AutoPart>, IAutoPartService
    {
<<<<<<< Updated upstream
        IAutoPartProcessor AutoPartProcessor = new AutoPartProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(AutoPartParam param)
        {
            AutoPartProcessor = new AutoPartProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(AutoPartProcessor.Create(param));
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

        public ApiResponse Create(List<AutoPartParam> param)
        {
            AutoPartProcessor = new AutoPartProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(AutoPartProcessor.Create(param));
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
            AutoPartProcessor = new AutoPartProcessor();
            Response = new ApiResponse();

            try
            {
                AutoPartProcessor.Delete(idList);
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
            AutoPartProcessor = new AutoPartProcessor();
            Response = new ApiResponse();

            try
            {
                AutoPartProcessor.Delete(id);
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
            AutoPartProcessor = new AutoPartProcessor();
            Response = new ApiResponse();

            try
            {
                AutoPartProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(AutoPartProcessor.Find(id));
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
            AutoPartProcessor = new AutoPartProcessor();
            Response = new ApiResponse();

            try
            {
                AutoPartProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(AutoPartProcessor.Find());
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

        public ApiResponse Update(long id, AutoPartParam param)
        {
            AutoPartProcessor = new AutoPartProcessor();
            Response = new ApiResponse();

            try
            {
                AutoPartProcessor.Update(id, param);
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

        public ApiResponse Update(List<AutoPartParam> param)
        {
            AutoPartProcessor = new AutoPartProcessor();
            Response = new ApiResponse();

            try
            {
                AutoPartProcessor.Update(param);

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

        public void ValidateParameters(AutoPartParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AutoPartParam> param)
        {
            throw new NotImplementedException();
        }
=======
        
>>>>>>> Stashed changes
    }
}
