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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        //----------------------------------------------
        public void BDelete(SocialMedia t)
        {
            _socialMediaDal.Delete(t);
        }

        public SocialMedia BGetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public List<SocialMedia> BGetList()
        {
            return _socialMediaDal.GetList();
        }

        public void BInsert(SocialMedia t)
        {
            _socialMediaDal.Insert(t);
        }

        public void BUpdate(SocialMedia t)
        {
            _socialMediaDal.Update(t);
        }
    }
}
