using lesson_2.DataAccess.Absract;
using lesson_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2.DataAccess
{
    public class CourseDal : ICourseDal<Course>
    {

        List<Course> courses;
        public CourseDal()
        {
            Course cSharp=new Course();
            cSharp.Id = 1;
            cSharp.CourseName = "c#";
            cSharp.CourseDescription = "C# la öğrenme";
            cSharp.Teacher = "Engin Demiroğ";
            cSharp.CategoryId = 1;


            Course python = new Course();
            python.Id = 2;
            python.CourseName = "python";
            python.CourseDescription = "python la öğrenme";
            python.Teacher = "Oğuzhan çırak";
            python.CategoryId = 1;
            courses = new List<Course>() {cSharp,python };
        }

        public List<Course> GetAll()
        {
           return courses;
        }
        public void Add(Course t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course t)
        {
            throw new NotImplementedException();
        }

        public Course Get(Course t)
        {
            throw new NotImplementedException();
        }

      
        public Course Update(Course t)
        {
            throw new NotImplementedException();
        }
    }
}
