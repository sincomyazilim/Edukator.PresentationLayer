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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }


        //------------------------------------------
        public void BDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact BGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> BGetList()
        {
            return _contactDal.GetList();
        }

        public void BInsert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void BUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
