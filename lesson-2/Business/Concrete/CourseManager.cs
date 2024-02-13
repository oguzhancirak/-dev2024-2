using lesson_2.DataAccess.Absract;
using lesson_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2.Business
{
    public class CourseManager
    {
        private ICourseDal<Course> _coursedal;
        public CourseManager(ICourseDal<Course> courseDal) 
        {
            _coursedal = courseDal;
        }
        public List<Course> GetAll()
        {
            return _coursedal.GetAll();

        }
    }
}
