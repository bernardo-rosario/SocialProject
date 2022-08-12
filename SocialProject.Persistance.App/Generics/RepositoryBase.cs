using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialProject.Persistence.App.Generics
{
    public class RepositoryBase<T, TPrimaryKey> : IRepositoryBase<T, TPrimaryKey> where T : class, IEntity<TPrimaryKey>
    {
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(ProjectoSolidarioDBContext dBContext)
        {
            _dbSet = dBContext.Set<T>();
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public bool Delete(TPrimaryKey id)
        {
            var entity = _dbSet.Remove(GetById(id));
            return entity != null;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(TPrimaryKey id)
        {
            return _dbSet.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
