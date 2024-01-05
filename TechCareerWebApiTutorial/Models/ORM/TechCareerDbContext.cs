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
        public DbSet<BlogCategory> BlogCategories { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<webUsers> webUsers { get; set; }
        public DbSet<TechWebUser> techWebUsers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Room> Rooms { get; set; }


    }
}
