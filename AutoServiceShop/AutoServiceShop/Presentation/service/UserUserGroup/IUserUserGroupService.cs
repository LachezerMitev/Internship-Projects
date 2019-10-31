using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.UserUserGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.UserUserGroup
{
    interface IUserUserGroupService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(UserUserGroupParam param);
        ApiResponse Create(List<UserUserGroupParam> param);

        ApiResponse Update(long id, UserUserGroupParam param);
        ApiResponse Update(List<UserUserGroupParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(UserUserGroupParam param);
        void ValidateParameters(List<UserUserGroupParam> param);
    }
}
