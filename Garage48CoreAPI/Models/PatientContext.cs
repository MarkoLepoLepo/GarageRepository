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
    }
}