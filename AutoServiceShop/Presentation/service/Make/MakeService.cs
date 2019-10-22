using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Make;
using AutoServiceShop.Business.Processor.Make;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Make
{
    class MakeService : IMakeService
    {
        IMakeProcessor MakeProcessor { get; set; }

        public ApiResponse Create(MakeParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<MakeParam> param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ApiResponse DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse FindByPK(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListAll()
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(long id, MakeParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<MakeParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(MakeParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<MakeParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
