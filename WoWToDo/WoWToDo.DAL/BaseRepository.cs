using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WoWToDo.Infrastructure;
using WoWToDo.Infrastructure.Interfaces;

namespace WoWToDo.DAL
{
    public class BaseRepository<TModel> : IRepository<TModel> where TModel : BaseModel, new()
    {
        /// <summary>
        /// The Db context.
        /// </summary>
        private readonly DbContext _dbContext;

        /// <summary>
        /// The current Db table.
        /// </summary>
        private readonly IDbSet<TModel> _currentDbSet;

        /// <summary>
        /// Indicates whether the repository state was changed.
        /// </summary>
        private bool _stateChanged;

        /// <summary>
        /// Indicates whether the inner resources are already disposed.
        /// </summary>
        private bool _disposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="dbContext">
        /// The Db context.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// When <paramref name="dbContext"/> is null.
        /// </exception>
        public BaseRepository(DbContext dbContext)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            _dbContext = dbContext;
            _currentDbSet = _dbContext.Set<TModel>();
        }

        /// <summary>
        /// Gets the db context.
        /// </summary>
        protected DbContext DbContext
        {
            get { return _dbContext; }
        }

        /// <summary>
        /// Gets the current db set.
        /// </summary>
        protected IDbSet<TModel> CurrentDbSet
        {
            get { return _currentDbSet; }
        }

        public TModel GetById(int id)
        {
            return FirstOrDefault(x => x.Id == id);
        }

        public ICollection<TModel> GetAll()
        {
            return _currentDbSet.Where(x => !x.IsDeleted).ToList();
        }

        public TModel FirstOrDefault(Expression<Func<TModel, bool>> filter)
        {
            return _currentDbSet.FirstOrDefault(filter);
        }

        public int Count()
        {
            return _currentDbSet.Count(x => !x.IsDeleted);
        }

        public bool Exist(Expression<Func<TModel, bool>> filter = null)
        {
            if (filter == null)
            {
                return _currentDbSet.Any(x => !x.IsDeleted);
            }

            return _currentDbSet.Where(x => !x.IsDeleted).Any(filter);
        }

        public virtual void AddOrUpdate(TModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            // if the pers exists in Db then we have to update it
            if (model.Id != 0)
            {
                var originalModel = this.GetById(model.Id);
                Update(originalModel, model);
                _stateChanged = true;
            }
            else
            {
                Add(model);
                _stateChanged = true;
            }
        }

        public virtual void AddOrUpdate(TModel[] models)
        {
            _dbContext.Set<TModel>().AddOrUpdate(models);
        }

        public virtual void Delete(int id)
        {
            var model = GetById(id);
            if (model != null)
            {
                _currentDbSet.Remove(model);
                _stateChanged = true;
            }
        }

        public virtual void Delete(TModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            Delete(model.Id);
        }

        public void SaveChanges()
        {
            if (_stateChanged)
            {
                _dbContext.SaveChanges();
                _stateChanged = false;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    //_dbContext?.Dispose();
                    _disposed = true;
                }
            }
        }

        protected virtual void Update(TModel modelFromDb, TModel model)
        {
            var entry = _dbContext.Entry(modelFromDb);
            entry.CurrentValues.SetValues(model);
        }

        protected virtual void Add(TModel model)
        {
            // if it is a new model then we have to insert it
            _currentDbSet.Add(model);
        }

        protected void SetStateChanged()
        {
            _stateChanged = true;
        }

        protected virtual void MarkAsDeleted(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _dbContext.Entry(entity).State = EntityState.Modified;
                _stateChanged = true;
            }
        }

        protected virtual void MarkAsDeleted(TModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            MarkAsDeleted(model.Id);
        }
    }
}
