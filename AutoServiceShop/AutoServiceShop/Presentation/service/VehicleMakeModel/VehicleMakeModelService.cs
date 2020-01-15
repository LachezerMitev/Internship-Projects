using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;
using AutoServiceShop.Business.Processor.VehicleMakeModel;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.VehicleMakeModel
{
    class VehicleMakeModelService : IVehicleMakeModelService
    {
<<<<<<< Updated upstream
        IVehicleMakeModelProcessor VehicleMakeModelProcessor = new VehicleMakeModelProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(VehicleMakeModelParam param)
        {
            VehicleMakeModelProcessor = new VehicleMakeModelProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(VehicleMakeModelProcessor.Create(param));
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

        public ApiResponse Create(List<VehicleMakeModelParam> param)
        {
            VehicleMakeModelProcessor = new VehicleMakeModelProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(VehicleMakeModelProcessor.Create(param));
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
            VehicleMakeModelProcessor = new VehicleMakeModelProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleMakeModelProcessor.Delete(idList);
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
            VehicleMakeModelProcessor = new VehicleMakeModelProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleMakeModelProcessor.Delete(id);
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
            VehicleMakeModelProcessor = new VehicleMakeModelProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleMakeModelProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(VehicleMakeModelProcessor.Find(id));
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
            VehicleMakeModelProcessor = new VehicleMakeModelProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleMakeModelProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(VehicleMakeModelProcessor.Find());
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

        public ApiResponse Update(long id, VehicleMakeModelParam param)
        {
            VehicleMakeModelProcessor = new VehicleMakeModelProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleMakeModelProcessor.Update(id, param);
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

        public ApiResponse Update(List<VehicleMakeModelParam> param)
        {
            VehicleMakeModelProcessor = new VehicleMakeModelProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleMakeModelProcessor.Update(param);

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

        public void ValidateParameters(VehicleMakeModelParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<VehicleMakeModelParam> param)
        {
            throw new NotImplementedException();
        }
=======
>>>>>>> Stashed changes
    }
}
