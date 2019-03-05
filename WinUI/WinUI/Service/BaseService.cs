using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using WinUI.Data;

namespace WinUI.Service
{
    public interface IBaseService<T> where T : class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        List<T> List();


    }
    public class BaseService<T> : IBaseService<T> where T : class
    {

        protected ChengQEntities db = new ChengQEntities();
        public virtual bool Add(T entity)
        {
            try
            {
                db.Set<T>().Add(entity);
                var result = db.SaveChanges();
                return result > 0 ? true : false;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public virtual bool Update(T entity)
        {
            ChengQEntities db1 = new ChengQEntities();
            db1.Set<T>().Attach(entity);
            db1.Entry(entity).State = EntityState.Modified;
            var result = db1.SaveChanges();
            return result > 0 ? true : false;
        }
        public virtual bool Delete(T entity)
        {

            db.Set<T>().Remove(entity);
            var result = db.SaveChanges();
            return result > 0 ? true : false;
        }
        public virtual List<T> List()
        {
            return db.Set<T>().ToList();
        }
    }
}
