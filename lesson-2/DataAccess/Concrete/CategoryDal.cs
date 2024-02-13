using lesson_2.DataAccess.Absract;
using lesson_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2.DataAccess
{
    public class CategoryDal : ICourseDal<Category>
    {
        List<Category> _categories;
        public CategoryDal()
        {
            Category software = new Category();
            software.Id = 1;
            software.CategoryName = "Yazılım";

            Category Hardware = new Category();
            Hardware.Id = 2;
            Hardware.CategoryName = "Donanım";

            _categories = new List<Category>() {software,Hardware };
            
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Add(Category category)
        {
             _categories.Add(category);
            
        }

        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }

        public Category Get(Category t)
        {
            throw new NotImplementedException();
        }

       
        public Category Update(Category t)
        {
            throw new NotImplementedException();
        }
    }
}
