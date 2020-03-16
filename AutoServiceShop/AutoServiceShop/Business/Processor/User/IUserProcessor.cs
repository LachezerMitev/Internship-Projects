using AutoServiceShop.Business.Processor.Common;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Dataaccess.Dao.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.User
{
    public interface IUserProcessor : IBaseProcessor<IUserParamConverter, IUserResultConverter, UserParam, UserResult, IUserDao, long, Data.Entity.User>
    {
        //UserResult Create(UserParam param);
        //List<UserResult> Create(List<UserParam> param);

        //void Update(long id, UserParam param);
        //void Update(List<UserParam> param);

        //void Delete(long id);
        //void Delete(List<long> idList);

        //UserResult Find(long id);
        //List<UserResult> Find();
    }
}
