using Hairdresser_Website.Models;
using Microsoft.EntityFrameworkCore;

namespace Hairdresser_Website.Data
{
    public class SalonDbContext : DbContext
    {
        public SalonDbContext(DbContextOptions<SalonDbContext> options) : base(options) { }


        public DbSet<Salon> Salons { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<EmployeeAvailability> EmployeeAvailability { get; set; } 
        public DbSet<SalonWorkingHours> SalonWorkingHours { get; set; }
        public DbSet<UnavailableSlot> UnavailableSlots { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            // Example: Add configurations here if necessary
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId); // Explicitly defining primary key if required

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.User) // العلاقة مع الكيان User
                .WithMany(u => u.Appointments) // العلاقة العكسية
                .HasForeignKey(a => a.UserId) // المفتاح الأجنبي
                .OnDelete(DeleteBehavior.Cascade); // تحديد سلوك الحذف


            // تحديد دقة Price في Service
            modelBuilder.Entity<Service>()
                .Property(s => s.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<User>()
            .HasKey(u => u.UserId);
        }
    }
}