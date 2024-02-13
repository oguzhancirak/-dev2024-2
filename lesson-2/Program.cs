using lesson_2.Business;
using lesson_2.DataAccess;
using lesson_2.DataAccess.Absract;
using lesson_2.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        List<Category> categories = categoryManager.GetAll();
        foreach (var item in categories)
        {
            Console.WriteLine(item.CategoryName);
        }
        Console.WriteLine("********************");
        CourseManager courseManager=new CourseManager(new CourseDal());
        List<Course> courses= courseManager.GetAll();
        foreach(var course in courses)
        {
            Console.WriteLine(course.CourseName);
        }
    }
}