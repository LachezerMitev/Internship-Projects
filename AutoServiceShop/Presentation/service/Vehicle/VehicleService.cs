using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Vehicle;
using AutoServiceShop.Business.Processor.Vehicle;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Vehicle
{
    class VehicleService : IVehicleService
    {
        IVehicleProcessor VehicleProcessor = new VehicleProcessor();
        public ApiResponse Response = new ApiResponse();

        public ApiResponse Create(VehicleParam param)
        {
            VehicleProcessor = new VehicleProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(VehicleProcessor.Create(param));
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

        public ApiResponse Create(List<VehicleParam> param)
        {
            VehicleProcessor = new VehicleProcessor();
            Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(VehicleProcessor.Create(param));
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
            VehicleProcessor = new VehicleProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleProcessor.Delete(idList);
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
            VehicleProcessor = new VehicleProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleProcessor.Delete(id);
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
            VehicleProcessor = new VehicleProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(VehicleProcessor.Find(id));
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
            VehicleProcessor = new VehicleProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(VehicleProcessor.Find());
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

        public ApiResponse Update(long id, VehicleParam param)
        {
            VehicleProcessor = new VehicleProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleProcessor.Update(id, param);
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

        public ApiResponse Update(List<VehicleParam> param)
        {
            VehicleProcessor = new VehicleProcessor();
            Response = new ApiResponse();

            try
            {
                VehicleProcessor.Update(param);

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

        public void ValidateParameters(VehicleParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<VehicleParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
