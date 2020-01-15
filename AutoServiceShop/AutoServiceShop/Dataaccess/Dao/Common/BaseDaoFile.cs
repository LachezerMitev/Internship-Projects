using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Common
{
    /// <summary>
    /// Data Access class for the local storage (JSON files)
    /// </summary>
    public abstract class BaseDaoFile<TEntity, TId, TStorage> : IBaseDao<TEntity, TId>
        where TStorage : BaseStorage<TEntity, TId>
        where TEntity : Data.Entity.Persistent

    {
        /// <summary>
        /// Get's the instance of the storage class
        /// </summary>
        private TStorage _storage = StorageInstanceFactory<TStorage>.Instance;

        private Dictionary<TId, TEntity> dictionary;

        /// <summary>
        /// Removes item from file via ID
        /// </summary>
        public void Delete(TId id)
        {
            dictionary = _storage.GetDictionary();

            dictionary.Remove(id);

            _storage.SaveInFile(_storage.GetPath(), dictionary);
        }


        /// <summary>
        /// Removes item from file via the entity itself
        /// </summary>
        public void Delete(TEntity entity)
        {
            dictionary = _storage.GetDictionary();

            dictionary.Remove(GetPK(entity));

            _storage.SaveInFile(_storage.GetPath(), dictionary);
        }

        /// <summary>
        /// Removes items from file via list of ID
        /// </summary>
        public void Delete(List<TId> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        /// <summary>
        /// Returns all items in the file
        /// </summary>
        public List<TEntity> Find()
        {
            dictionary = _storage.GetDictionary();
            return dictionary.Select(kvp => kvp.Value).ToList();
        }
        
        /// <summary>
        /// Returns a specific item from the file via the ID
        /// </summary>
        public TEntity Find(TId id)
        {
            dictionary = _storage.GetDictionary();

            return dictionary
                .Where(x => x.Key.Equals(id)).Select(entity => entity.Value)
                .Single();
        }

        /// <summary>
        /// Returns a items from file that corespond to the given field name and value
        /// </summary>
        public List<TEntity> FindByField(string field, string value)
        {
            dictionary = _storage.GetDictionary();

            return dictionary.Values
                .Where(entity => entity.GetType().GetProperty(field).GetValue(entity, null)
                .ToString().Equals(value, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        /// <summary>
        /// Adds an item to the file
        /// </summary>
        public TEntity Save(TEntity entity)
        {
            dictionary = _storage.GetDictionary();

            dictionary.Add(GetPK(entity), entity);

            _storage.SaveInFile(_storage.GetPath(), dictionary);

            return entity;
        }

        /// <summary>
        /// Adds an items to the file via list of entities
        /// </summary>
        public List<TEntity> Save(List<TEntity> entity)
        {
            entity.ForEach(x => Save(x));

            return entity;
        }

        /// <summary>
        /// Updates a specific entity
        /// </summary>
        public TEntity Update(TEntity entity)
        {

            Delete(GetPK(entity));
            Save(entity);

            return entity;
        }

        /// <summary>
        /// Updates items in a file from a list
        /// </summary>
        public List<TEntity> Update(List<TEntity> entity)
        {
            entity.ForEach(x => Update(x));

            return entity;
        }

        /// <summary>
        /// Returns the PK of an entity
        /// </summary>
        protected abstract TId GetPK(TEntity entity);
    }
}
