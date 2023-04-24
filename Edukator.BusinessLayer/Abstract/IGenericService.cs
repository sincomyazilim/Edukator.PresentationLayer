using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T:class
    {
        void BInsert(T t);
        void BDelete(T t);
        void BUpdate(T t);
        List<T> BGetList();
        T BGetById(int id);
    }
}
