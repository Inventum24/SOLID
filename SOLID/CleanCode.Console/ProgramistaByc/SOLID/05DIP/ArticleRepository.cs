using System;
using System.Collections.Generic;

namespace CleanCode.Console.ProgramistaByc.SOLID._05DIP
{
    internal class ArticleRepository : IArticleRepository, IDisposable
    {
        private readonly IErpDatabaseContext _dbContext;

        public ArticleRepository(IErpDatabaseContext erpDatabaseContext)
        {
            throw new NotImplementedException();
        }

        public Article GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetEntities()
        {
            //return _dbContext.Article.Find(id);
            throw new NotImplementedException();
        }

        public void Add(Article entity)
        {
            //_dbContext.Article.Add(entity);
            throw new NotImplementedException();
        }

        public void Remove(Article entity)
        {
            //_dbContext.Article.Remove(entity);
            throw new NotImplementedException();
        }

        public void Update(Article entity)
        {
            //var a = _dbContext.Entry(entity).State = EntityState.Modified;
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Article> IRepository<Article>.GetEntities()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}