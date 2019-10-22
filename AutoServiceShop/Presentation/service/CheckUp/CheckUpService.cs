using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Business.Processor.CheckUp;
using AutoServiceShop.Business.Processor.Converter.CheckUp;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.CheckUp
{
    class CheckUpService : ICheckUpService
    {
        ICheckUpProcessor CheckUpProcessor { get; set; }

        public ApiResponse Create(CheckUpParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<CheckUpParam> param)
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

        public ApiResponse Update(long id, CheckUpParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<CheckUpParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(CheckUpParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<CheckUpParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
