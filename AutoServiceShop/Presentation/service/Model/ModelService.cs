using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Model;
using AutoServiceShop.Business.Processor.Model;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.Model
{
    class ModelService : IModelService
    {
        IModelProcessor ModelProcessor { get; set; }

        public ApiResponse Create(ModelParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<ModelParam> param)
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

        public ApiResponse Update(long id, ModelParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<ModelParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(ModelParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<ModelParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
