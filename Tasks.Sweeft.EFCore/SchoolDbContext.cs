using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tasks.Sweeft.EFCore.Models;

namespace Tasks.Sweeft.EFCore
{
    public class SchoolDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Teacher>? Teachers { get; set; }
        public DbSet<Pupil>? Pupils { get; set; }
        public DbSet<TeacherPupil>? TeacherPupils { get; set; }

        public SchoolDbContext()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json")
                .Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Default"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherPupil>().HasKey(tp => new { tp.TeacherID, tp.PupilID });
        }
    }
}
