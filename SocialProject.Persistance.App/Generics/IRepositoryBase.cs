using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialProject.Persistence.App.Generics
{
    public interface IRepositoryBase<T, TPrimaryKey> where T : class, IEntity<TPrimaryKey>
    {
        T GetById(TPrimaryKey id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        T Add(T entity);
        bool Delete(TPrimaryKey id);
    }
}
