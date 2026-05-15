using Microsoft.EntityFrameworkCore;
using  ClinicWeb.Models;

namespace  ClinicWeb.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Veterinarian> Veterinarians { get; set; }
        public DbSet<ClinicService> Services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<AppointmentService> AppointmentServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Client>()
                .HasMany(c => c.Pets)
                .WithOne(p => p.Client)
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Pet>()
                .HasMany(p => p.Appointments)
                .WithOne(a => a.Pet)
                .HasForeignKey(a => a.PetId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Veterinarian>()
                .HasMany(v => v.Appointments)
                .WithOne(a => a.Veterinarian)
                .HasForeignKey(a => a.VeterinarianId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.MedicalRecord)
                .WithOne(m => m.Appointment)
                .HasForeignKey<MedicalRecord>(m => m.AppointmentId);

            modelBuilder.Entity<ClinicService>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(300);
                entity.Property(e => e.Price).HasPrecision(18, 2);
            });
        }
    }
}