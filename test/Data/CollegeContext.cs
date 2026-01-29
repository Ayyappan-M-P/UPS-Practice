using Microsoft.EntityFrameworkCore;
using StudentApi.Models;

namespace StudentApi.Data
{
    public class CollegeContext : DbContext
    {
        public CollegeContext(DbContextOptions<CollegeContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; } = null!;
    }
}
