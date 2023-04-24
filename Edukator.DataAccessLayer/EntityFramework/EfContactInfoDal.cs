using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Repository;
using Edukator.EntityLayer.Concrete;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfContactInfoDal:GenericRepository<ContactInfo>,IContactInfoDal
    {
    }
}
