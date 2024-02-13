using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string Teacher { get; set; }
        

    }
}
