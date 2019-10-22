using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.User;
using AutoServiceShop.Business.Processor.Converter.User;

namespace AutoServiceShop.Business.Processor.User
{
    class UserProcessor : IUserProcessor
    {
        IUserDao UserDao { get; set; }

        IUserParamConverter UserParamConverter { get; set; }
        IUserResultConverter UserResultConverter { get; set; }

        public UserResult Create(UserParam param)
        {
            throw new NotImplementedException();
        }

        public List<UserResult> Create(List<UserParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public UserResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<UserResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, UserParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<UserParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
