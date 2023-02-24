using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IGenericDal<T> where T: class, new()
	{
		void Add(T entity);
		void Delete(T entity);
		void Update(T entity);
		List<T> GetAllList();
		T GetByID(int ID);
	}
}
