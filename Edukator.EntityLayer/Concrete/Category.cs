using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
   public class Category
    {//9
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<Course> Courses { get; set; }
    }
}
//bir kategorının bırden fazla kursu olabılır