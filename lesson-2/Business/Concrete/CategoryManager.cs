using lesson_2.DataAccess;
using lesson_2.DataAccess.Absract;
using lesson_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2.Business
{
    public class CategoryManager
    {
        private ICourseDal<Category> _categoryDal;
        public CategoryManager(ICourseDal<Category> courseDal )
        {
            _categoryDal = courseDal;
            
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
