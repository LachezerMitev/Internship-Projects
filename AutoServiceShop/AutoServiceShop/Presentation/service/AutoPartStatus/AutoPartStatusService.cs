using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.AutoPartStatus;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.AutoPartStatus
{
    class AutoPartStatusService : IAutoPartStatusService
    {
        AutoPartStatusProcessor AutoPartStatusProcessor { get; set; }

        public ApiResponse Create(AutoPartStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<AutoPartStatusParam> param)
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

        public ApiResponse Update(long id, AutoPartStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<AutoPartStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(AutoPartStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<AutoPartStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
