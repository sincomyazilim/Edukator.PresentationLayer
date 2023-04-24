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
    public class CourseManager : ICourseService
    {//11
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }


        //--------------------------------------------------------------
        public void BDelete(Course t)
        {
            _courseDal.Delete(t);
        }

        public Course BGetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public List<Course> BGetList()
        {
            return _courseDal.GetList();
        }

        public void BInsert(Course t)
        {
            _courseDal.Insert(t);
        }

        public void BUpdate(Course t)
        {
            _courseDal.Update(t);
        }
    }
}
