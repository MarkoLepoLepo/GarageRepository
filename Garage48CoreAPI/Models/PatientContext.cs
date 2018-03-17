using System;
using Microsoft.EntityFrameworkCore;

namespace Garage48CoreAPI.Models
{
    public class PatientContext : DbContext
    {
        public PatientContext(DbContextOptions<PatientContext> options) : base(options)
        {}
        public DbSet<PatientInformation> PatientInformations { get; set; }
        public DbSet<PersonalDatum> PersonalData { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicalData> MedicalDatas { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<PatientDoctorMapping> PatientDoctorMappings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientDoctorMapping>().HasKey(t => new { t.PatientId, t.DoctorId });
            base.OnModelCreating(modelBuilder);
        }
    }
}