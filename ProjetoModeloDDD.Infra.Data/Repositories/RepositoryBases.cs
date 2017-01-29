using ProjetModeloDDD.Dommain.Interfaces;
using ProjetoModeloDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjetoModeloContext DB = new ProjetoModeloContext();
        public void Add(TEntity obj)
        {
            DB.Set<TEntity>().Add(obj);
            DB.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return DB.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DB.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            DB.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            DB.Set<TEntity>().Remove(obj);
            DB.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
