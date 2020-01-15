using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.VehicleStatus;
using AutoServiceShop.Business.Processor.VehicleStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.VehicleStatus
{
    class VehicleStatusService : IVehicleStatusService
    {
<<<<<<< Updated upstream
        IVehicleStatusProcessor VehicleStatusProcessor = new VehicleStatusProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(VehicleStatusParam param)
        {
            VehicleStatusProcessor = new VehicleStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(VehicleStatusProcessor.Create(param));
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

        public ApiResponse Create(List<VehicleStatusParam> param)
        {
            VehicleStatusProcessor = new VehicleStatusProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(VehicleStatusProcessor.Create(param));
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
            VehicleStatusProcessor = new VehicleStatusProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleStatusProcessor.Delete(idList);
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
            VehicleStatusProcessor = new VehicleStatusProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleStatusProcessor.Delete(id);
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
            VehicleStatusProcessor = new VehicleStatusProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleStatusProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(VehicleStatusProcessor.Find(id));
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
            VehicleStatusProcessor = new VehicleStatusProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleStatusProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(VehicleStatusProcessor.Find());
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

        public ApiResponse Update(long id, VehicleStatusParam param)
        {
            VehicleStatusProcessor = new VehicleStatusProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleStatusProcessor.Update(id, param);
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

        public ApiResponse Update(List<VehicleStatusParam> param)
        {
            VehicleStatusProcessor = new VehicleStatusProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleStatusProcessor.Update(param);

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

        public void ValidateParameters(VehicleStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<VehicleStatusParam> param)
        {
            throw new NotImplementedException();
        }
=======
>>>>>>> Stashed changes
    }
}
