using Microsoft.EntityFrameworkCore;

namespace TechCareerWebApiTutorial.Models.ORM
{
    public class TechCareerDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GQ3I6OJ; Database=TechCareerDb;User Id=sa;Password=1;");
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Employee> Employees { get; set; }
       
    }
}
