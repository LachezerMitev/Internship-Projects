using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Employee;
using AutoServiceShop.Business.Processor.Converter.Employee;

namespace AutoServiceShop.Business.Processor.Employee
{
    class EmployeeProcessor : IEmployeeProcessor
    {
        private IEmployeeParamConverter _employeeParamConverter;
        public IEmployeeParamConverter EmployeeParamConverter
        {
            set => _employeeParamConverter = value;
            get
            {
                if (_employeeParamConverter == null)
                {
                    _employeeParamConverter = new EmployeeParamConverter();
                    return _employeeParamConverter;
                }
                else
                {
                    return _employeeParamConverter;
                }
            }
        }

        private IEmployeeResultConverter _employeeResultConverter;
        public IEmployeeResultConverter EmployeeResultConverter
        {
            set => _employeeResultConverter = value;
            get
            {
                if (_employeeResultConverter == null)
                {
                    _employeeResultConverter = new EmployeeResultConverter();
                    return _employeeResultConverter;
                }
                else
                {
                    return _employeeResultConverter;
                }
            }
        }

        private IEmployeeDao _employeeDao;
        public IEmployeeDao EmployeeDataObject
        {
            set => _employeeDao = value;
            get
            {
                if (_employeeDao == null)
                {
                    _employeeDao = new EmployeeDao();
                    return _employeeDao;
                }
                else
                {
                    return _employeeDao;
                }
            }
        }


        public EmployeeResult Create(EmployeeParam param)
        {

            Data.Entity.Employee entity = _employeeParamConverter.Convert(param, null);

            _employeeDao.Save(entity);

            return _employeeResultConverter.Convert(entity);
        }

        public List<EmployeeResult> Create(List<EmployeeParam> param)
        {
            List<Data.Entity.Employee> entities = new List<Data.Entity.Employee>();
            foreach (var item in param)
            {
                entities.Add(_employeeParamConverter.Convert(item, null));
            }
            _employeeDao.Save(entities);
            List<EmployeeResult> result = new List<EmployeeResult>();
            foreach (var item in entities)
            {
                result.Add(_employeeResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _employeeDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Employee> entity = new List<Data.Entity.Employee>();
            foreach (var id in idList)
            {
                entity.Add(_employeeDao.Find(id));
            }
            foreach (var id in idList)
            {
                _employeeDao.Delete(id);
            }
        }

        public EmployeeResult Find(long id)
        {
            try
            {
                Data.Entity.Employee entity = _employeeDao.Find(id);
                EmployeeResult result = _employeeResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<EmployeeResult> Find()
        {
            List<Data.Entity.Employee> Employees = _employeeDao.Find();
            List<EmployeeResult> results = new List<EmployeeResult>();
            foreach (var item in Employees)
            {
                results.Add(_employeeResultConverter.Convert(item));
            }
            return results;
        }

        public List<EmployeeResult> FindByField(string field, string value)
        {
            List<Data.Entity.Employee> Employees = _employeeDao.FindByField(field, value);
            List<EmployeeResult> results = new List<EmployeeResult>();
            foreach (var item in Employees)
            {
                results.Add(_employeeResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, EmployeeParam param)
        {
            Data.Entity.Employee oldEntity = _employeeDao.Find(id);
            Data.Entity.Employee newEntity = _employeeParamConverter.Convert(param, oldEntity);
            _employeeDao.Update(newEntity);
        }

        public void Update(List<EmployeeParam> param)
        {
            List<Data.Entity.Employee> entity = new List<Data.Entity.Employee>();
            foreach (var item in param)
            {
                Data.Entity.Employee oldEntity = _employeeDao.Find(item.Id);
                Data.Entity.Employee newEntity = _employeeParamConverter.Convert(item, oldEntity);
                _employeeDao.Update(newEntity);
            }
        }
    }
}
