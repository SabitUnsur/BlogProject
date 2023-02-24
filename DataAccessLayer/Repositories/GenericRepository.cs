using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class, new()
	{
		Context db = new Context();
		public void Add(T entity)
		{
			db.Add(entity);
			db.SaveChanges();
		}

		public void Delete(T entity)
		{
			db.Remove(entity);
			db.SaveChanges();
		}

		public void Update(T entity)
		{
			db.Update(entity);
			db.SaveChanges();
		}

		public List<T> GetAllList()
		{
			return db.Set<T>().ToList();
		}

		public T GetByID(int ID)
		{
			return db.Set<T>().Find(ID);
		}	
	}
}
