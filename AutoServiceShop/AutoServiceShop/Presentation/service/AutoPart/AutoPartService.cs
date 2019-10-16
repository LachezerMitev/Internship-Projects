using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.AutoPart;
using AutoServiceShop.Business.Processor.Converter.AutoPart;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.AutoPart
{
    class AutoPartService : IAutoPartService
    {
        AutoPartProcessor AutoPartProcessor { get; set; }

        public ApiResponse Create(AutoPartParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<AutoPartParam> param)
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

        public ApiResponse Update(long id, AutoPartParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<AutoPartParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(AutoPartParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AutoPartParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
