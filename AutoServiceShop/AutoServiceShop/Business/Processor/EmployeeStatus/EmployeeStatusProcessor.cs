using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.EmployeeStatus;
using AutoServiceShop.Business.Processor.Converter.EmployeeStatus;

namespace AutoServiceShop.Business.Processor.EmployeeStatus
{
    class EmployeeStatusProcessor : IEmployeeStatusProcessor
    {
        private IEmployeeStatusParamConverter _employeeStatusParamConverter;
        public IEmployeeStatusParamConverter EmployeeStatusParamConverter
        {
            set => _employeeStatusParamConverter = value;
            get
            {
                if (_employeeStatusParamConverter == null)
                {
                    _employeeStatusParamConverter = new EmployeeStatusParamConverter();
                    return _employeeStatusParamConverter;
                }
                else
                {
                    return _employeeStatusParamConverter;
                }
            }
        }

        private IEmployeeStatusResultConverter _employeeStatusResultConverter;
        public IEmployeeStatusResultConverter EmployeeStatusResultConverter
        {
            set => _employeeStatusResultConverter = value;
            get
            {
                if (_employeeStatusResultConverter == null)
                {
                    _employeeStatusResultConverter = new EmployeeStatusResultConverter();
                    return _employeeStatusResultConverter;
                }
                else
                {
                    return _employeeStatusResultConverter;
                }
            }
        }

        private IEmployeeStatusDao _employeeStatusDao;
        public IEmployeeStatusDao EmployeeStatusDataObject
        {
            set => _employeeStatusDao = value;
            get
            {
                if (_employeeStatusDao == null)
                {
                    _employeeStatusDao = new EmployeeStatusDao();
                    return _employeeStatusDao;
                }
                else
                {
                    return _employeeStatusDao;
                }
            }
        }


        public EmployeeStatusResult Create(EmployeeStatusParam param)
        {

            Data.Entity.EmployeeStatus entity = _employeeStatusParamConverter.Convert(param, null);

            _employeeStatusDao.Save(entity);

            return _employeeStatusResultConverter.Convert(entity);
        }

        public List<EmployeeStatusResult> Create(List<EmployeeStatusParam> param)
        {
            List<Data.Entity.EmployeeStatus> entities = new List<Data.Entity.EmployeeStatus>();
            foreach (var item in param)
            {
                entities.Add(_employeeStatusParamConverter.Convert(item, null));
            }
            _employeeStatusDao.Save(entities);
            List<EmployeeStatusResult> result = new List<EmployeeStatusResult>();
            foreach (var item in entities)
            {
                result.Add(_employeeStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _employeeStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.EmployeeStatus> entity = new List<Data.Entity.EmployeeStatus>();
            foreach (var id in idList)
            {
                entity.Add(_employeeStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                _employeeStatusDao.Delete(id);
            }
        }

        public EmployeeStatusResult Find(long id)
        {
            try
            {
                Data.Entity.EmployeeStatus entity = _employeeStatusDao.Find(id);
                EmployeeStatusResult result = _employeeStatusResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<EmployeeStatusResult> Find()
        {
            List<Data.Entity.EmployeeStatus> EmployeeStatuss = _employeeStatusDao.Find();
            List<EmployeeStatusResult> results = new List<EmployeeStatusResult>();
            foreach (var item in EmployeeStatuss)
            {
                results.Add(_employeeStatusResultConverter.Convert(item));
            }
            return results;
        }

        public List<EmployeeStatusResult> FindByField(string field, string value)
        {
            List<Data.Entity.EmployeeStatus> EmployeeStatuss = _employeeStatusDao.FindByField(field, value);
            List<EmployeeStatusResult> results = new List<EmployeeStatusResult>();
            foreach (var item in EmployeeStatuss)
            {
                results.Add(_employeeStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, EmployeeStatusParam param)
        {
            Data.Entity.EmployeeStatus oldEntity = _employeeStatusDao.Find(id);
            Data.Entity.EmployeeStatus newEntity = _employeeStatusParamConverter.Convert(param, oldEntity);
            _employeeStatusDao.Update(newEntity);
        }

        public void Update(List<EmployeeStatusParam> param)
        {
            List<Data.Entity.EmployeeStatus> entity = new List<Data.Entity.EmployeeStatus>();
            foreach (var item in param)
            {
                Data.Entity.EmployeeStatus oldEntity = _employeeStatusDao.Find(item.Id);
                Data.Entity.EmployeeStatus newEntity = _employeeStatusParamConverter.Convert(item, oldEntity);
                _employeeStatusDao.Update(newEntity);
            }
        }
    }
}
