using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage48CoreAPI.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Description { get; set; }
        public string Contacts { get; set; }
        public string Tag { get; set; }

        public virtual List<PatientDoctorMapping> Patients { get; set; }
        public virtual List<MedicalRecord> PatientsRecords { get; set; }

    }
}
