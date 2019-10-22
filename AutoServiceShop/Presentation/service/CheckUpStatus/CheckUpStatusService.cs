using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.CheckUpStatus;
using AutoServiceShop.Business.Processor.Converter.CheckUpStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.CheckUpStatus
{
    class CheckUpStatusService : ICheckUpStatusService
    {
        ICheckUpStatusProcessor CheckUpStatusProcessor { get; set; }

        public ApiResponse Create(CheckUpStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<CheckUpStatusParam> param)
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

        public ApiResponse Update(long id, CheckUpStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<CheckUpStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(CheckUpStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<CheckUpStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
