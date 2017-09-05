using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console.ProgramistaByc.SOLID._05DIP
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetEntities();
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        void Save();
    }
}
