using Microsoft.EntityFrameworkCore;
using Pagination_Test.Models;

namespace Pagination_Test.Data
{
    public class ApplicationDbContext : DbContext
    {
        List<Student> listOfStudents = new List<Student>();
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            for (int i = 1; i <= 100; i++)
            {
                listOfStudents.Add(new Student()
                {
                    Id = i,
                    FirstName = "Mr. Tom",
                    LastName = "Any",
                    Faculty = "Math",
                    Age = i+1
                });
            }
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(listOfStudents);
        }
    }
}
