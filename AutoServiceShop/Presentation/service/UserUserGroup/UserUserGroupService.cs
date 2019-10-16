using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.UserUserGroup;
using AutoServiceShop.Business.Processor.UserUserGroup;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.UserUserGroup
{
    class UserUserGroupService : IUserUserGroupService
    {
        UserUserGroupProcessor UserUserGroupProcessor { get; set; }

        public ApiResponse Create(UserUserGroupParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<UserUserGroupParam> param)
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

        public ApiResponse Update(long id, UserUserGroupParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<UserUserGroupParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(UserUserGroupParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<UserUserGroupParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
