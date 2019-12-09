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
        private IVehicleMakeModelProcessor _vehicleMakeModelProcessor;
        public IVehicleMakeModelProcessor VehicleMakeModelProcessor
        {
            set => _vehicleMakeModelProcessor = value;
            get
            {
                if (_vehicleMakeModelProcessor == null)
                {
                    _vehicleMakeModelProcessor = new VehicleMakeModelProcessor();
                    return _vehicleMakeModelProcessor;
                }
                else
                {
                    return _vehicleMakeModelProcessor;
                }
            }
        }

        public ApiResponse Create(VehicleMakeModelParam param)
        {
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_vehicleMakeModelProcessor.Create(param));
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
            ApiResponse Response = new ApiResponse();

            try
            {
                Response.text = JsonConverter.JsonConverter.ObjToJson(_vehicleMakeModelProcessor.Create(param));
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
                _vehicleMakeModelProcessor.Delete(idList);
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
                _vehicleMakeModelProcessor.Delete(id);
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
                _vehicleMakeModelProcessor.Find(id);
                Response.text = "Account with this PK has been found" + Environment.NewLine + JsonConverter.JsonConverter.ObjToJson(_vehicleMakeModelProcessor.Find(id));
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
                _vehicleMakeModelProcessor.Find();
                Response.text = JsonConverter.JsonConverter.ObjToJson(_vehicleMakeModelProcessor.Find());
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _vehicleMakeModelProcessor.Update(id, param);
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
            ApiResponse Response = new ApiResponse();

            try
            {
                _vehicleMakeModelProcessor.Update(param);

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
    }
}
