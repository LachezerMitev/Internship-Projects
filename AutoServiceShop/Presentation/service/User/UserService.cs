using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Business.Processor.User;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.User
{
    class UserService : IUserService
    {
        IUserProcessor UserProcessor { get; set; }

        public ApiResponse Create(UserParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<UserParam> param)
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

        public ApiResponse Update(long id, UserParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<UserParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(UserParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<UserParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
