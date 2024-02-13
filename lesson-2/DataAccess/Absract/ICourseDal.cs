using lesson_2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2.DataAccess.Absract
{
    public interface ICourseDal<T> where T : class
    {
        List<T> GetAll();
        T Get(T t);

        void Add(T t);
        void Delete(T t);
        T Update(T t);

    }
}
