using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.VehicleMakeModel;
using AutoServiceShop.Business.Processor.Converter.VehicleMakeModel;

namespace AutoServiceShop.Business.Processor.VehicleMakeModel
{
    class VehicleMakeModelProcessor : IVehicleMakeModelProcessor
    {
        VehicleMakeModelDao VehicleMakeModelDao { get; set; }

        VehicleMakeModelParamConverter VehicleMakeModelParamConverter { get; set; }
        VehicleMakeModelResultConverter VehicleMakeModelResultConverter { get; set; }

        public VehicleMakeModelResult Create(VehicleMakeModelParam param)
        {
            throw new NotImplementedException();
        }

        public List<VehicleMakeModelResult> Create(List<VehicleMakeModelParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public VehicleMakeModelResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<VehicleMakeModelResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, VehicleMakeModelParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<VehicleMakeModelParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
