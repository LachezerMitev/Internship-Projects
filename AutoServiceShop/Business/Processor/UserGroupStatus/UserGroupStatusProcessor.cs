using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.UserGroupStatus;
using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;

namespace AutoServiceShop.Business.Processor.UserGroupStatus
{
    class UserGroupStatusProcessor : IUserGroupStatusProcessor
    {
        IUserGroupStatusDao UserGroupStatusDao { get; set; }

        IUserGroupStatusParamConverter UserGroupStatusParamConverter { get; set; }
        IUserGroupStatusResultConverter UserGroupStatusResultConverter { get; set; }

        public UserGroupStatusResult Create(UserGroupStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<UserGroupStatusResult> Create(List<UserGroupStatusParam> param)
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

        public UserGroupStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<UserGroupStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, UserGroupStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<UserGroupStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
