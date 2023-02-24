using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		EfCategoryRepository efCategoryRepository;

		public CategoryManager()
		{
			efCategoryRepository = new EfCategoryRepository();
		}

		public void AddCategory(Category category)
		{
			efCategoryRepository.Add(category);
		}

		public void DeleteCategory(Category category)
		{
			efCategoryRepository.Delete(category);
		}

		public Category GetCategoryByID(int categoryID)
		{
			return efCategoryRepository.GetByID(categoryID);
		}

		public List<Category> GetCategoryList()
		{
			return efCategoryRepository.GetAllList();
		}

		public void UpdateCategory(Category category)
		{
			efCategoryRepository.Update(category);
		}
	}
}
