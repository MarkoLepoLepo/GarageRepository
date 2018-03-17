using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Garage48CoreAPI.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PatientContext(
                serviceProvider.GetRequiredService<DbContextOptions<PatientContext>>()))
            {
                context.Database.EnsureDeleted();
                context.Database.Migrate();
                //// Look for any movies.
                //if (context.PatientInformations.Any())
                //{
                //    return;   // DB has been seeded
                //}
                
                //if (context.PersonalData.Any())
                //{
                //    return;   // DB has been seeded
                //}
               
                #region patients
                context.PatientInformations.AddRange(
                    new PatientInformation
                    {
                        Id = 1,
                        FirstName = "Harry",
                        LastName = "Smith",
                        UserName = "smith",
                        Password = "smithpass"
                    },

                    new PatientInformation
                    {
                        Id = 2,
                        FirstName = "Jonh",
                        LastName = "Doe",
                        UserName = "doe",
                        Password = "doepass"
                    }

                );
                #endregion
                
                #region Medical history

                context.MedicalDatas.AddRange(
                    new MedicalData { PatientId = 1, Id = 1 }
                    , new MedicalData { PatientId = 2, Id = 2 }
                    );

                #endregion

                #region personal data
                context.PersonalData.AddRange(
                    new PersonalDatum
                    {
                        UniqueId = "Harry"
                    },

                    new PersonalDatum
                    {
                        UniqueId = "Foo"
                    }
                    );
                #endregion

                #region doctor
                context.Doctors.AddRange(
                    new Doctor { Id = 1, FirstName = "Frank", LastName = "Doctor", UserName = "doctor1", Password="doctor1" }
                    , new Doctor { Id = 2, FirstName = "John", LastName = "Doctor", UserName = "doctor2", Password = "doctor2" }
                    );
                #endregion

                context.SaveChanges();
            
                #region Mappings

                context.PatientDoctorMappings.AddRange(
                    new PatientDoctorMapping { DoctorId = 1, PatientId = 1, IsActive = true}
                    ,new PatientDoctorMapping { DoctorId = 1, PatientId = 2, IsActive = false }
                    , new PatientDoctorMapping { DoctorId = 2, PatientId = 1, IsActive = true}
                    , new PatientDoctorMapping { DoctorId = 2, PatientId = 2, IsActive = true }
                    );

                #endregion

                #region Records

                context.MedicalRecords.AddRange(
                    new MedicalRecord {Id = 1, DoctorId = 1, MediacalDataId = 1, Symptoms = "stomachache" }
                    ,new MedicalRecord { Id = 2, DoctorId = 1, MediacalDataId = 1, Symptoms = "headache" }
                    , new MedicalRecord { Id = 3, DoctorId = 2, MediacalDataId = 2, Symptoms = "broken leg" }
                    , new MedicalRecord { Id = 4, DoctorId = 1, MediacalDataId = 2, Symptoms = "poisoning" }
                    );

                #endregion

                context.SaveChanges();
            }
        }
    }
}