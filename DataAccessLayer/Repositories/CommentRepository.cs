using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class CommentRepository : IGenericDal<Comment>
	{
		public void Add(Comment entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Comment entity)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetAllList()
		{
			throw new NotImplementedException();
		}

		public Comment GetByID(int ID)
		{
			throw new NotImplementedException();
		}

		public void Update(Comment entity)
		{
			throw new NotImplementedException();
		}
	}
}
