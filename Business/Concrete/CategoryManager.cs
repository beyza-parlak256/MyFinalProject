using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categorDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            // İş kodları
            return _categorDal.GetAll();
        }

        // Select * from Categories where CategoryId = 3
        public Category GetById(int categoryId)
        {
            return _categorDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
