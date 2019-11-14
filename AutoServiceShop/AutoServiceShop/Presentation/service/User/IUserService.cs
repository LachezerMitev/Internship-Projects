using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.User
{
    interface IUserService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(UserParam param);
        ApiResponse Create(List<UserParam> param);

        ApiResponse Update(long id, UserParam param);
        ApiResponse Update(List<UserParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(UserParam param);
        void ValidateParameters(List<UserParam> param);
    }
}
