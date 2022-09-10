using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstract
{
    public interface IEntityResopsitory<TEntity>
    {
        public void Add(TEntity entity);
        public void Delete(TEntity entity);
        public void Update(TEntity entity);
        public  Task<List<TEntity>> GetAll(Expression<Func<TEntity,bool>> filter);
        public Task<TEntity> Get(Expression<Func<TEntity, bool>>filter);

    }
}
