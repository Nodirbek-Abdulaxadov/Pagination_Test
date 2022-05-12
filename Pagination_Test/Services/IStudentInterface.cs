using Pagination_Test.Helpers;
using Pagination_Test.Models;

namespace Pagination_Test.Services
{
    public interface IStudentInterface
    {
        PagedList<Student> GetStudents(StudentParametrs parametrs);
        List<Student> GetStudents();
    }
}
