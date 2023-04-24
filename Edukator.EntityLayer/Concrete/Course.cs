using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class Course
    {//9
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Review { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
//bır kursun mutlaka bır kategorısı vardır