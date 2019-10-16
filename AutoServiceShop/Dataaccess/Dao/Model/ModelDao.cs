using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.Model
{
    class ModelDao : IModelDao
    {
        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Data.Entity.Model entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public List<Data.Entity.Model> Find()
        {
            throw new NotImplementedException();
        }

        public Data.Entity.Model Find(long id)
        {
            throw new NotImplementedException();
        }

        public Data.Entity.Model Save(Data.Entity.Model entity)
        {
            throw new NotImplementedException();
        }

        public List<Data.Entity.Model> Save(List<Data.Entity.Model> entity)
        {
            throw new NotImplementedException();
        }

        public Data.Entity.Model Update(Data.Entity.Model entity)
        {
            throw new NotImplementedException();
        }

        public List<Data.Entity.Model> Update(List<Data.Entity.Model> entity)
        {
            throw new NotImplementedException();
        }
    }
}
