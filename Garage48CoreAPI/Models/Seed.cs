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
                // Look for any movies.
                if (context.PatientInformations.Any())
                {
                    return;   // DB has been seeded
                }
                
                if (context.PersonalData.Any())
                {
                    return;   // DB has been seeded
                }
                
                context.PatientInformations.AddRange(
                    new PatientInformation
                    {
                        FirstName = "Harry",
                        LastName = "Potter"
                    },

                    new PatientInformation
                    {
                        FirstName = "Jonh",
                        LastName = "Doe"
                    },

                    new PatientInformation
                    {
                        FirstName = "Hrrr",
                        LastName = "Ptttt"
                    },

                    new PatientInformation
                    {
                        FirstName = "Abc",
                        LastName = "Defg"
                    },
                    new PatientInformation
                    {
                        FirstName = "Olol",
                        LastName = "Lololo"
                    },
                    new PatientInformation
                    {
                        FirstName = "Mumba",
                        LastName = "Umba"
                    }
                );
                context.PersonalData.AddRange(
                    new PersonalDatum
                    {
                        UniqueId = "Harry"
                    },

                    new PersonalDatum
                    {
                        UniqueId = "Foo"
                    },

                    new PersonalDatum
                    {
                        UniqueId = "Bar"
                    },

                    new PersonalDatum
                    {
                        UniqueId = "Some"
                    },
                    new PersonalDatum
                    {
                        UniqueId = "Shit"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}