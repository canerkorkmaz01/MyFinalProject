using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;   
        }
        //public List<Category> GetAll()
        //{

        //}

        //public Category GetById(int categoryId)
        //{

        //}

        public IDataResult<List<Category>> GetAll()
        {
            //if (DateTime.Now.Hour == 12)
            //{
            //    return new ErrorDataResult<List<Category>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.ProductListed);
            
        }

       public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryId == categoryId));
        }
    }
}
