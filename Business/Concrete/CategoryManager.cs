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
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //iş kodları!!
            return _categoryDal.GetAll();
        }
        // Select * from categories where CategoryId = 3------ aşağıdaki kod bunu çalıştırır tabi sen ne gönderirsen 3'ün yerine
        public Category GetById(int categotyId)
        {
            return _categoryDal.Get(c => c.CategoryId == categotyId);   

        }
    }
}
