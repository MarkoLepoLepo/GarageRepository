using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Garage48CoreAPI.Models
{
    public class PatientDoctorMapping
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        public PatientInformation Patient { get; set; }
        public Doctor Doctor { get; set; }

        public string Tag { get; set; }

        public bool IsActive { get; set; }
    }
}
