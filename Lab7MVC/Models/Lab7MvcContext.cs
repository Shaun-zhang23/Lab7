using System.Data.Entity;

namespace Lab7MVC.Models
{
    public class Lab7MvcContext : DbContext
    {
        public Lab7MvcContext()
            : base("name=Lab7MvcContext")
        {
        }

        public DbSet<UniversityCampus> UniversityCampuses { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure the one-to-many relationship explicitly with Fluent API
            modelBuilder.Entity<UniversityCampus>()
                .HasMany(campus => campus.Students)
                .WithRequired(student => student.UniversityCampus)
                .HasForeignKey(student => student.CampusID)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
