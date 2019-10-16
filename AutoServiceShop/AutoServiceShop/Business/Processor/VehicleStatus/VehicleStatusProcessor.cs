using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.VehicleStatus;
using AutoServiceShop.Business.Processor.Converter.VehicleStatus;

namespace AutoServiceShop.Business.Processor.VehicleStatus
{
    class VehicleStatusProcessor : IVehicleStatusProcessor
    {
        VehicleStatusDao VehicleStatusDao { get; set; }

        VehicleStatusParamConverter VehicleStatusParamConverter { get; set; }
        VehicleStatusResultConverter VehicleStatusResultConverter { get; set; }

        public VehicleStatusResult Create(VehicleStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<VehicleStatusResult> Create(List<VehicleStatusParam> param)
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

        public VehicleStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<VehicleStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, VehicleStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<VehicleStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
