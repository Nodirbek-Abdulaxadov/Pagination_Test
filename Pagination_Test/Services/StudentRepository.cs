using Pagination_Test.Data;
using Pagination_Test.Helpers;
using Pagination_Test.Models;

namespace Pagination_Test.Services
{
    public class StudentRepository : IStudentInterface
    {
        private readonly ApplicationDbContext dbContext;

        public StudentRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public PagedList<Student> GetStudents(StudentParametrs parametrs)
        {
            return PagedList<Student>.ToPagedList(dbContext.Students.OrderBy(s => s.LastName),
                                    parametrs.PageNumber, parametrs.PageSize);
        }

        public List<Student> GetStudents()
        {
            return dbContext.Students.ToList();
        }
    }
}
