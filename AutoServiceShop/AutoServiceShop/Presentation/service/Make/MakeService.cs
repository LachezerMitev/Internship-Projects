using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Make;
using AutoServiceShop.Business.Processor.Make;
using AutoServiceShop.Data.Common;
using AutoServiceShop.Dataaccess.Dao.Make;
using AutoServiceShop.Presentation.service.Common;

namespace AutoServiceShop.Presentation.service.Make
{
    public class MakeService
        : BaseService<IMakeProcessor, IMakeParamConverter, IMakeResultConverter, MakeParam, MakeResult, IMakeDao, long, Data.Entity.Make>, IMakeService
    {
<<<<<<< Updated upstream
        IMakeProcessor MakeProcessor = new MakeProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(MakeParam param)
        {
            MakeProcessor = new MakeProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(MakeProcessor.Create(param));
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

        public ApiResponse Create(List<MakeParam> param)
        {
            MakeProcessor = new MakeProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(MakeProcessor.Create(param));
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
            MakeProcessor = new MakeProcessor();
            Response = new ApiResponse();

            try
            {
                MakeProcessor.Delete(idList);
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
            MakeProcessor = new MakeProcessor();
            Response = new ApiResponse();

            try
            {
                MakeProcessor.Delete(id);
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
            MakeProcessor = new MakeProcessor();
            Response = new ApiResponse();

            try
            {
                MakeProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(MakeProcessor.Find(id));
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
            MakeProcessor = new MakeProcessor();
            Response = new ApiResponse();

            try
            {
                MakeProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(MakeProcessor.Find());
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

        public ApiResponse Update(long id, MakeParam param)
        {
            MakeProcessor = new MakeProcessor();
            Response = new ApiResponse();

            try
            {
                MakeProcessor.Update(id, param);
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

        public ApiResponse Update(List<MakeParam> param)
        {
            MakeProcessor = new MakeProcessor();
            Response = new ApiResponse();

            try
            {
                MakeProcessor.Update(param);

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

        public void ValidateParameters(MakeParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<MakeParam> param)
        {
            throw new NotImplementedException();
        }
=======
        
>>>>>>> Stashed changes
    }
}
