using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Vehicle;
using AutoServiceShop.Business.Processor.Converter.Vehicle;

namespace AutoServiceShop.Business.Processor.Vehicle
{
    class VehicleProcessor : IVehicleProcessor
    {
        VehicleDao VehicleDao { get; set; }

        VehicleParamConverter VehicleParamConverter { get; set; }
        VehicleResultConverter VehicleResultConverter { get; set; }

        public VehicleResult Create(VehicleParam param)
        {
            throw new NotImplementedException();
        }

        public List<VehicleResult> Create(List<VehicleParam> param)
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

        public VehicleResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<VehicleResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, VehicleParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<VehicleParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
