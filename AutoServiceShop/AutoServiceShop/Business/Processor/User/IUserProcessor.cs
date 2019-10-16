using AutoServiceShop.Business.Processor.Converter.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.User
{
    interface IUserProcessor
    {
        UserResult Create(UserParam param);
        List<UserResult> Create(List<UserParam> param);

        void Update(long id, UserParam param);
        void Update(List<UserParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        UserResult Find(long id);
        List<UserResult> Find();
    }
}
