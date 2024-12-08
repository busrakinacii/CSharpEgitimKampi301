using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        CampContext contex = new CampContext();
        private readonly DbSet<T> _object;

        //ctor tab tab
        //Entity State Kullnaımı
        public GenericRepository()
        {
            _object = contex.Set<T>();
        }
        public void Delete(T entity)
        {
            var deletedEntity = contex.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            contex.SaveChanges();

        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void insert(T entity)
        {
            var addedEntity = contex.Entry(entity);
            addedEntity.State = EntityState.Added;
            contex.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity = contex.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            contex.SaveChanges();
        }
    }
}
