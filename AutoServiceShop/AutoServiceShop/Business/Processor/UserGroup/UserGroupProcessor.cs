using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.UserGroup;
using AutoServiceShop.Business.Processor.Converter.UserGroup;

namespace AutoServiceShop.Business.Processor.UserGroup
{
    class UserGroupProcessor : IUserGroupProcessor
    {
        UserGroupDao UserGroupDao { get; set; }

        UserGroupParamConverter UserGroupParamConverter { get; set; }
        UserGroupResultConverter UserGroupResultConverter { get; set; }

        public UserGroupResult Create(UserGroupParam param)
        {
            throw new NotImplementedException();
        }

        public List<UserGroupResult> Create(List<UserGroupParam> param)
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

        public UserGroupResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<UserGroupResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, UserGroupParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<UserGroupParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
