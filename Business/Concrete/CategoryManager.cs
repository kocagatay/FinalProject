﻿using Business.Abstract;
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

        public IDataResult<List<Category>> GetAll()
        {
            //iş kodları!!
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }
        // Select * from categories where CategoryId = 3------ aşağıdaki kod bunu çalıştırır tabi sen ne gönderirsen 3'ün yerine
        public IDataResult<Category> GetById(int categotyId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categotyId));

        }
    }
}
