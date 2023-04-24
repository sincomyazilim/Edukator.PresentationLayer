using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;

namespace Edukator.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {//11
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //-------------------------------------------------
        public void BDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public Category BGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> BGetList()
        {
            return _categoryDal.GetList();
        }

        public void BInsert(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void BUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
