using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WoWToDo.Infrastructure.Interfaces
{
    public interface IRepository<TModel> : IDisposable where TModel : BaseModel, new()
    {
        TModel GetById(int id);
        
        ICollection<TModel> GetAll();
        
        TModel FirstOrDefault(Expression<Func<TModel, bool>> filter);
        
        int Count();
        
        bool Exist(Expression<Func<TModel, bool>> filter = null);
        
        void AddOrUpdate(TModel model);
        
        void AddOrUpdate(TModel[] models);
        
        void Delete(int id);
        
        void Delete(TModel model);
        
        void SaveChanges();
    }
}
